using System;
using Empresa.Ecommerce.Application.DTO;
using Empresa.Ecommerce.Application.Interface;
using Empresa.Ecommerce.Transversal.Common;
using Empresa.Ecommerce.Domain.Entity;
using Empresa.Ecommerce.Domain.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;

namespace Empresa.Ecommerce.Application.Main
{
    public class CustomerApplication : ICustomersApplication
    {
        private readonly ICustomersDomain _customersDomain;
        private readonly IMapper _mapper;

        public CustomerApplication(ICustomersDomain customersDomain, IMapper mapper)
        {
            _customersDomain = customersDomain;
            _mapper = mapper;
        }

        #region Metodos Sincronos

        public Response<bool> Insert(CustomersDTO customerDTO)
        {
            var response = new Response<bool>();

            try
            {
                //Transformamos de CustomersDTO a Customer
                var customer = _mapper.Map<Customers>(customerDTO);

                response.Data = _customersDomain.Insert(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<bool> Update(CustomersDTO customerDTO)
        {
            var response = new Response<bool>();

            try
            {
                //Transformamos de CustomersDTO a Customer
                var customer = _mapper.Map<Customers>(customerDTO);

                response.Data = _customersDomain.Update(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<bool> Delete(String customerId)
        {
            var response = new Response<bool>();

            try
            {
                response.Data = _customersDomain.Delete(customerId);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminado con Exito";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<CustomersDTO> Get(String customerId)
        {
            var response = new Response<CustomersDTO>();

            try
            {
                var customer = _customersDomain.Get(customerId);

                //Transformamos de Customer a CustomersDTO
                response.Data = _mapper.Map<CustomersDTO>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
                else
                {
                    response.Message = "No se encontro registro";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<IEnumerable<CustomersDTO>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();

            try
            {
                var customers = _customersDomain.GetAll();

                //Transformamos de Customer a CustomersDTO
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Lista Exitosa";
                }
                else
                {
                    response.Message = "No se encontraron registros";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        #endregion

        #region Metodos Asincronos

        public async Task<Response<bool>> InsertAsync(CustomersDTO customerDTO)
        {
            var response = new Response<bool>();

            try
            {
                //Transformamos de CustomersDTO a Customer
                var customer = _mapper.Map<Customers>(customerDTO);

                response.Data = await _customersDomain.InsertAsync(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CustomersDTO customerDTO)
        {
            var response = new Response<bool>();

            try
            {
                //Transformamos de CustomersDTO a Customer
                var customer = _mapper.Map<Customers>(customerDTO);

                response.Data = await _customersDomain.UpdateAsync(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<bool>> DeleteAsync(String customerId)
        {
            var response = new Response<bool>();

            try
            {
                response.Data = await _customersDomain.DeleteAsync(customerId);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminado con Exito";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<CustomersDTO>> GetAsync(String customerId)
        {
            var response = new Response<CustomersDTO>();

            try
            {
                var customer = await _customersDomain.GetAsync(customerId);

                //Transformamos de Customer a CustomersDTO
                response.Data = _mapper.Map<CustomersDTO>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
                else
                {
                    response.Message = "No se encontro registro";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();

            try
            {
                var customers = await _customersDomain.GetAllAsync();

                //Transformamos de Customer a CustomersDTO
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Lista Exitosa";
                }
                else
                {
                    response.Message = "No se encontraron registros";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }


        #endregion
    }
}
