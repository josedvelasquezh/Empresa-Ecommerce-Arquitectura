using System;
using Empresa.Ecommerce.Domain.Entity;
using Empresa.Ecommerce.Domain.Interface;
using Empresa.Ecommerce.Infraestruture.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Empresa.Ecommerce.Domain.Core
{
    //Logicas de reglas de negocio van aqui para ir a la capa de infraestructura
    public class CustomersDomain : ICustomersDomain
    {
        //Tiene que consumir una interface de la capa inferior
        private readonly ICustomerRepository _customerRepository;

        //Inyeccion de dependencias
        public CustomersDomain(ICustomerRepository customerRepository)
        {
            //Le asignamos el valor de nuestro constructor
            _customerRepository = customerRepository;
        }

        #region Metodos Sincronos

        public bool Insert(Customers customers)
        {
            return _customerRepository.Insert(customers);
        }

        public bool Update(Customers customers)
        {
            return _customerRepository.Update(customers);
        }

        public bool Delete(String customerId)
        {
            return _customerRepository.Delete(customerId);
        }

        public Customers Get(String customerId)
        {
            return _customerRepository.Get(customerId);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customerRepository.GetAll();
        }

        #endregion

        #region Metodos Asincronos

        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _customerRepository.InsertAsync(customers);
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customerRepository.UpdateAsync(customers);
        }

        public async Task<bool> DeleteAsync(String customerId)
        {
            return await _customerRepository.DeleteAsync(customerId);
        }

        public async Task<Customers> GetAsync(String customerId)
        {
            return await _customerRepository.GetAsync(customerId);
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        #endregion
    }
}
