using System;
using System.Collections.Generic;
using System.Text;
using Empresa.Ecommerce.Application.DTO;
using Empresa.Ecommerce.Transversal.Common;
using System.Threading.Tasks;

namespace Empresa.Ecommerce.Application.Interface
{
    public interface ICustomersApplication
    {
        #region Metodos Sincronos

        Response<bool> Insert(CustomersDTO customerDTO);
        Response<bool> Update(CustomersDTO customerDTO);
        Response<bool> Delete(String customerId);
        Response<CustomersDTO> Get(String customerId);
        Response<IEnumerable<CustomersDTO>> GetAll();

        #endregion

        #region Metodos Asincronos

        Task<Response<bool>> InsertAsync(CustomersDTO customerDTO);
        Task<Response<bool>> UpdateAsync(CustomersDTO customerDTO);
        Task<Response<bool>> DeleteAsync(String customerId);
        Task<Response<CustomersDTO>> GetAsync(String customerId);
        Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync();

        #endregion

    }
}
