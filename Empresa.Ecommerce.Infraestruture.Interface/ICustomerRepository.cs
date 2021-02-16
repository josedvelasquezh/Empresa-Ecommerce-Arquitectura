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
        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(String customerId);
        Customers Get(String customerId);
        IEnumerable<Customers> GetAll();

        #endregion

        #region Metodos Asincronos
        Task<bool> InsertAsync(Customers customer);
        Task<bool> UpdateAsync(Customers customer);
        Task<bool> DeleteAsync(String customerId);
        Task<Customers> GetAsync(String customerId);
        Task<IEnumerable<Customers>> GetAllAsync();

        #endregion
    }
}
