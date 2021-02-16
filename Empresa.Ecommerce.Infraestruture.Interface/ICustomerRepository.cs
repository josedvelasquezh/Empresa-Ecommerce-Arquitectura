using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Empresa.Ecommerce.Domain.Entity;

namespace Empresa.Ecommerce.Infraestruture.Interface
{
    //Interface de las operaciones para ser implementados
    public interface ICustomerRepository
    {
        #region Metodos Sincronos

        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(String customerId);
        Customer Get(String customerId);
        IEnumerable<Customer> GetAll();

        #endregion

        #region Metodos Asincronos
        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(String customerId);
        Task<Customer> GetAsync(String customerId);
        Task<IEnumerable<Customer>> GetAllAsync();

        #endregion
    }
}
