using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DapperQuery
{
    public partial class Repository
    {
        private readonly string conectionString = @"Server=.;Initial Catalog=DapperDb; integrated security=true";

        public int Add()
        {
            string Sql = "INSERT INTO Customers (Name , LastName) Values (@Name , @LastName); " +
                            "Select SCOPE_IDENTITY()";
            var connection = new SqlConnection(conectionString);
            var result = connection.QuerySingle<int>(Sql, new { Name = "sara", LastName = "brm" });
            return result;
        }

        public List<Order> GetOrders()
        {
            string sql = "SELECT TOP 10  * FROM Orders AS O INNER JOIN OrderDetails AS OD ON O.Id = OD.OrderId";
            var connection = new SqlConnection(conectionString);
            var orderDic = new Dictionary<long, Order>();

            var OrderList = connection.Query<Order, OrderDetail, Order>(sql,
                (order, orderDetail) =>
                {
                    Order entity;
                    if (!orderDic.TryGetValue(order.Id, out entity))
                    {
                        entity = order;
                        entity.OrderDetails = new List<OrderDetail>();
                        orderDic.Add(entity.Id, entity);
                    }
                    entity.OrderDetails.Add(orderDetail);
                    return entity;
                },
                splitOn: "Id")
                .Distinct()
                .ToList();
            return OrderList;
        }

        public void QuerMultiple()
        {
            string sql = "SELECT * FROM Orders ; SELECT * FROM Invoice ;  ";
            var connection = new SqlConnection(conectionString);
            var result = connection.QueryMultiple(sql);

            var orders = result.Read<Order>().ToList();
            var invoice = result.Read<Invoice>().ToList();
        }

        public void Queries()
        {
            string sql = "SELECT * FROM Orders ;";
            var connection = new SqlConnection(conectionString);
            var result = connection.QueryFirst<Order>(sql);
            var resultDefault = connection.QueryFirstOrDefault<Order>(sql);
            var resultSingle = connection.QuerySingle<Order>(sql);
            var resultSingleOrDefault = connection.QuerySingleOrDefault<Order>(sql);
        }

        public List<Order> RunSP()
        {
            string sql = "SELECTOrders";
            var connection = new SqlConnection(conectionString);
            var result = connection.Query<Order>(sql, CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Order> GetInvoice()
        {
            string sql = "SELECT * FROM Orders  AS O INNER JOIN Invoice AS I ON O.Id = I.Id";
            var connection = new SqlConnection(conectionString);

            var invoice = connection.Query<Order, Invoice, Order>(
                sql, (order, invoice) =>
                {
                    order.Invoice = invoice;
                    return order;
                }, splitOn: "Id")
                .Distinct()
                .ToList();
            return invoice;
        }
    }
}
