using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostLog.AppFailEntitys
{
   
    public class Exceptions
    {
        public Exceptions(FailureOccurrence parent)
        {
            parent.Exceptions.Add(this);
        }
        public String ExceptionType { get; set; }
        public String ExceptionMessage { get; set; }
        public String StackTrace { get; set; }
    }


}
