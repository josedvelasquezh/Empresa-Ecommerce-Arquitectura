using System;
using Empresa.Ecommerce.Domain.Entity;
using Empresa.Ecommerce.Infraestruture.Interface;
using Empresa.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Empresa.Ecommerce.Infraestructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        //Variable de conexion
        private readonly IConnectionFactory _connectionFactory;

        //Utilizamos inyeccion de dependencia para no usar new en instacias
        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Metodos Sincronos

        //Metodo Insert
        public bool Insert(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersInsert";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                //Si es una consulta con dapper se utiliza para ejecucion Execute
                var result = connection.Execute(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return result > 0;
            }
        }

        public bool Update(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersUpdate";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                //Si es una consulta con dapper se utiliza para ejecucion Execute
                var result = connection.Execute(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return result > 0;
            }
        }

        public bool Delete(String customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersDelete";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerId);

                //Si es una consulta con dapper se utiliza para ejecucion Execute
                var result = connection.Execute(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return result > 0;
            }
        }

        public Customers Get(String customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersGetByID";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerId);

                //Si es una consulta con dapper se utiliza QuerySingle
                var customer = connection.QuerySingle<Customers>(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return customer;
            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersList";

                //El uso de Query de manera automatica retorna un ienumerable
                var customers = connection.Query<Customers>(querySP, commandType: CommandType.StoredProcedure);

                //retorna lista
                return customers;
            }
        }

        #endregion

        #region Metodos Asincronos

        //Metodo Insert
        public async Task<bool> InsertAsync(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersInsert";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                //Si es una consulta con dapper se utiliza para ejecucion Execute
                var result = await connection.ExecuteAsync(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersUpdate";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                //Si es una consulta con dapper se utiliza para ejecucion Execute
                var result = await connection.ExecuteAsync(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(String customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersDelete";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerId);

                //Si es una consulta con dapper se utiliza para ejecucion Execute
                var result = await connection.ExecuteAsync(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return result > 0;
            }
        }

        public async Task<Customers> GetAsync(String customerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersGetByID";

                //Parametros para el StoredProcedure
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerId);

                //Si es una consulta con dapper se utiliza QuerySingle
                var customer = await connection.QuerySingleAsync<Customers>(querySP, param: parameters, commandType: CommandType.StoredProcedure);

                //Si es mayor a 0 se realizo con exito la operacion
                return customer;
            }
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                //Nombre de StoredProcedure
                String querySP = "CustomersList";

                //El uso de Query de manera automatica retorna un ienumerable
                var customers = await connection.QueryAsync<Customers>(querySP, commandType: CommandType.StoredProcedure);

                //retorna lista
                return customers;
            }
        }

        #endregion
    }
}
