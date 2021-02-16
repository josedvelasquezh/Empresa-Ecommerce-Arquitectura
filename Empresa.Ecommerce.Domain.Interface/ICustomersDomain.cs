using System;
using System.Collections.Generic;
using System.Text;
using Empresa.Ecommerce.Domain.Entity;
using System.Threading.Tasks;

namespace Empresa.Ecommerce.Domain.Interface
{
    //Son las mismas operaciones que ya realizamos en la interface ICustomerRepository
    public interface ICustomersDomain
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
