using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooCommerceDomain.Models;
using WooCommerceDomain.Models.DbModels;

namespace WooCommerceWorkerService.Services
{
    public class DbService : IDbService
    {

        public void AddOrder(DbOrderModel dbOrderModel)
        {
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");

            var addressId = db.QuerySingle<int>(@" INSERT INTO Address (Street, City, PostCode) OUTPUT INSERTED.Id VALUES (@Street, @City, @PostCode);", new { dbOrderModel.Client.Address.Street, dbOrderModel.Client.Address.City, dbOrderModel.Client.Address.PostCode });
            var clientId = db.QuerySingle<int>(@" INSERT INTO Client (FirstName, LastName, Email, Phone, AddressId) OUTPUT INSERTED.Id VALUES (@FirstName, @LastName, @Email, @Phone, @AddressId);", new { dbOrderModel.Client.FirstName, dbOrderModel.Client.LastName, dbOrderModel.Client.Email, dbOrderModel.Client.Phone, addressId });
            var tt = db.QuerySingle<int>(@" INSERT INTO [Order] (Id, Status, DateCreated, ProductName, Total, DaysCount, DateStart, DateEnd, DietDescription, ClientId) OUTPUT INSERTED.Id VALUES (@Id, @Status, @DateCreated, @ProductName, @Total, @DaysCount, @DateStart, @DateEnd, @DietDescription, @ClientId)"
                            , new { dbOrderModel.Id, dbOrderModel.Status, dbOrderModel.DateCreated, dbOrderModel.ProductName, dbOrderModel.Total, dbOrderModel.DaysCount, dbOrderModel.DateStart, dbOrderModel.DateEnd, dbOrderModel.DietDescription, clientId });

        }

        public List<DbProductModel> GetProducts()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT Id, Name FROM [Product]");
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");
            return db.Query<DbProductModel>(sql.ToString()).ToList();
        }

        public string GetCreateDateOfLastOrder()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT Max(DateCreated) FROM [Order]");
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");
            return db.QuerySingle<string>(sql.ToString());
        }

        public List<DbOrderModel> GetOrdersForSingleDayByDay(string date)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT * FROM [Order] WHERE DateEnd >= @date AND DateStart <= @date AND Id NOT IN (SELECT OrderId FROM ExcludedDays WHERE ExcludedDay = @date)");
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");
            return db.Query<DbOrderModel>(sql.ToString(), new { date }).ToList();
        }

        public List<DayDetailsModel> GetOrdersDetailsForSingleDayByDay(string date)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT o.Id, c.FirstName, c.LastName, o.ProductName, o.DietDescription, a.Street, a.City, a.PostCode, c.Phone, c.Email ");
            sql.Append("FROM [Order] o INNER JOIN [Client] c ON o.ClientId = c.Id INNER JOIN Address a ON c.AddressId = a.Id ");
            sql.Append("WHERE DateEnd >= @date AND DateStart <= @date AND o.Id NOT IN (SELECT OrderId FROM ExcludedDays WHERE ExcludedDay = @date)");
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");
            return db.Query<DayDetailsModel>(sql.ToString(), new { date }).ToList();
        }

        public void AddExcludedDay(int orderId, DateTime date)
        {
            var sqlQuery = "INSERT INTO ExcludedDays VALUES (@orderID, @date)";
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");
            db.Execute(sqlQuery, new { orderId, date });
        }

        public void AddProducts(List<DbProductModel> product)
        {
            var sqlQueries = GetProductSqlsInBatchesToInsert(product);
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");
            db.Execute("DELETE FROM [Product]");
            foreach (var sqlQuery in sqlQueries)
            {
                db.Execute(sqlQuery);
            }
        }

        public int GetMaxOrderid()
        {
            var sql = new StringBuilder();
            sql.Append("Select MAX(id) FROM [Order]");
            using var db = new SqlConnection("server=LT-30015;database=WooCommerce;uid=WooAdmin;password=WooAdmin10");
            try
            {
                return db.QuerySingle<int>(sql.ToString());
            }
            catch (Exception)
            {
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
