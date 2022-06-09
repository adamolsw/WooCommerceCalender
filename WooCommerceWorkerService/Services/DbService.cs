using Dapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WooCommerceDomain.Models;
using WooCommerceDomain.Models.DbModels;

namespace WooCommerceWorkerService.Services
{
    public class DbService : IDbService
    {
        private string _conn;
        private ILogger<DbService> _logger;
        public DbService(ILogger<DbService> logger)
        {
            _logger = logger;
            _conn = ConfigurationManager.ConnectionStrings["prod"].ConnectionString;
        }

        public void AddOrder(DbOrderModel dbOrderModel)
        {
            _logger.LogInformation("Start - Add order to database");
            try
            {
                using var db = new SqlConnection(_conn);
                var addressId = db.QuerySingle<int>(@" INSERT INTO Address (Street, City, PostCode) OUTPUT INSERTED.Id VALUES (@Street, @City, @PostCode);", new { dbOrderModel.Client.Address.Street, dbOrderModel.Client.Address.City, dbOrderModel.Client.Address.PostCode });
                var clientId = db.QuerySingle<int>(@" INSERT INTO Client (FirstName, LastName, Email, Phone, AddressId) OUTPUT INSERTED.Id VALUES (@FirstName, @LastName, @Email, @Phone, @AddressId);", new { dbOrderModel.Client.FirstName, dbOrderModel.Client.LastName, dbOrderModel.Client.Email, dbOrderModel.Client.Phone, addressId });
                var result = db.QuerySingle<int>(@" INSERT INTO [Order] (Id, Status, DateCreated, ProductName, Total, DaysCount, DateStart, DateEnd, DietDescription, ClientId) OUTPUT INSERTED.Id VALUES (@Id, @Status, @DateCreated, @ProductName, @Total, @DaysCount, @DateStart, @DateEnd, @DietDescription, @ClientId)"
                                , new { dbOrderModel.Id, dbOrderModel.Status, dbOrderModel.DateCreated, dbOrderModel.ProductName, dbOrderModel.Total, dbOrderModel.DaysCount, dbOrderModel.DateStart, dbOrderModel.DateEnd, dbOrderModel.DietDescription, clientId });
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
            }
            _logger.LogInformation("End - Add order to database");

        }

        public List<DbProductModel> GetProducts()
        {
            try
            {
                _logger.LogInformation("Start - Get products from database");
                var sql = new StringBuilder();
                sql.Append("SELECT Id, Name FROM [Product]");
                using var db = new SqlConnection(_conn);
                var result = db.Query<DbProductModel>(sql.ToString()).ToList();
                _logger.LogInformation($"End - Get products from database. Found {result.Count} products.");
                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
                return new List<DbProductModel>();
            }
        }

        public string GetCreateDateOfLastOrder()
        {
            try
            {
                _logger.LogInformation("Start - Get date of last order from database");
                var sql = new StringBuilder();
                sql.Append("SELECT Max(DateCreated) FROM [Order]");
                using var db = new SqlConnection(_conn);
                var result = db.QuerySingle<string>(sql.ToString());
                _logger.LogInformation($"End - Get date of last order from database. Last order date is {result}");
                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
                return string.Empty;
            }

        }

        public List<DbOrderModel> GetOrdersForSingleDayByDay(string date)
        {
            try
            {
                _logger.LogInformation("Start - Orders for single day from database");
                DateTime dateTime = new DateTime(2022, 07, 11);
                if (DateTime.Now < dateTime)
                {
                    var sql = new StringBuilder();
                    sql.Append("SELECT * FROM [Order] WHERE DateEnd >= @date AND DateStart <= @date AND Id NOT IN (SELECT OrderId FROM ExcludedDays WHERE ExcludedDay = @date)");
                    using var db = new SqlConnection(_conn);
                    var result = db.Query<DbOrderModel>(sql.ToString(), new { date }).ToList();
                    _logger.LogInformation($"End - Orders for single day from database. Found {result.Count} order for day {date}.");
                    return result;
                }
                _logger.LogInformation($"Your licence has expired. Please contact with administrator");
                return new List<DbOrderModel>();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
                return new List<DbOrderModel>();
            }
        }

        public List<DayDetailsModel> GetOrdersDetailsForSingleDayByDay(string date)
        {
            try
            {
                _logger.LogInformation("Start - Orders details for single day from database");
                DateTime dateTime = new DateTime(2022, 07, 11);
                if (DateTime.Now < dateTime)
                {
                    var sql = new StringBuilder();
                    sql.Append("SELECT o.Id, c.FirstName, c.LastName, o.ProductName, o.DietDescription, a.Street, a.City, a.PostCode, c.Phone, c.Email ");
                    sql.Append("FROM [Order] o INNER JOIN [Client] c ON o.ClientId = c.Id INNER JOIN Address a ON c.AddressId = a.Id ");
                    sql.Append("WHERE DateEnd >= @date AND DateStart <= @date AND o.Id NOT IN (SELECT OrderId FROM ExcludedDays WHERE ExcludedDay = @date)");
                    using var db = new SqlConnection(_conn);
                    var result = db.Query<DayDetailsModel>(sql.ToString(), new { date }).ToList();
                    _logger.LogInformation($"End - Orders details for single day from database. Found {result.Count} orders for day {date}.");
                    return result;
                }
                _logger.LogInformation($"Your licence has expired. Please contact with administrator");
                return new List<DayDetailsModel>();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
                return new List<DayDetailsModel>();
            }

        }

        public void AddExcludedDay(int orderId, DateTime date)
        {
            try
            {
                _logger.LogInformation("Start - Add excluded day to database");
                var sqlQuery = "INSERT INTO ExcludedDays VALUES (@orderID, @date)";
                using var db = new SqlConnection(_conn);
                db.Execute(sqlQuery, new { orderId, date });
                _logger.LogInformation("End - Add excluded day to database");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
            }

        }

        public void AddProducts(List<DbProductModel> product)
        {
            try
            {
                _logger.LogInformation("Start - Add products to database");
                var sqlQueries = GetProductSqlsInBatchesToInsert(product);
                using var db = new SqlConnection(_conn);
                db.Execute("DELETE FROM [Product]");
                foreach (var sqlQuery in sqlQueries)
                {
                    db.Execute(sqlQuery);
                }
                _logger.LogInformation("End - Add products to database");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
            }
        }

        public int GetMaxOrderid()
        {
            try
            {
                _logger.LogInformation("Start - max order id from database");
                var sql = new StringBuilder();
                sql.Append("Select MAX(id) FROM [Order]");
                using var db = new SqlConnection(_conn);
                var result =  db.QuerySingle<int>(sql.ToString());
                _logger.LogInformation($"End - max order id from database, Max order id is {result}");
                return result;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Database error");
                return 1;
            }
        }


        private static IList<string> GetProductSqlsInBatchesToInsert(List<DbProductModel> lookupData)
        {
            var insertSql = "INSERT INTO [Product] VALUES ";
            var valuesSql = "('{0}', '{1}')";
            var batchSize = 1000;
            var sqlsToExecute = new List<string>();
            var numberOfBatches = (int)Math.Ceiling((double)lookupData.Count / batchSize);

            for (int i = 0; i < numberOfBatches; i++)
            {
                var dataToInsert = lookupData.Skip(i * batchSize).Take(batchSize);
                var valuesToInsert = dataToInsert.Select(u => string.Format(valuesSql, u.Id, u.Name));
                sqlsToExecute.Add(insertSql + string.Join(',', valuesToInsert));
            }
            return sqlsToExecute;
        }
    }
}
