using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        //base resulta gönderilecek elemanı tutar
        public ErrorResult(string message) : base(false, message)
        {//mesaj vermek istiyorsam

        }
        public ErrorResult() : base(false)
        {//mesaj vermek istemiyorsam

        }
    }
}
