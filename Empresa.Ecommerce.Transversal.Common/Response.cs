using System;

namespace Empresa.Ecommerce.Transversal.Common
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public String Message { get; set; }
    }
}
