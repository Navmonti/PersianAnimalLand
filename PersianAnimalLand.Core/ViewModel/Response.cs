using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.Core.ViewModel
{
    public class Response<T> : IResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
