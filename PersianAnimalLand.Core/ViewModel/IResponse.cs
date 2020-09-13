using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.Core.ViewModel
{
    public interface IResponse<TResult>
    {
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        TResult Result { get; set; }
    }
}
