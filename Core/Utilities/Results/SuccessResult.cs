using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base resulta gönderilecek elemanı tutar
        public SuccessResult(string message) : base(true, message)
        {//mesaj vermek istiyorsam

        }
        public SuccessResult() : base(true)
        {//mesaj vermek istemiyorsam

        }
    }
}
