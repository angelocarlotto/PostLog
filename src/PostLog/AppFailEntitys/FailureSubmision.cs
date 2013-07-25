using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostLog.AppFailEntitys
{

    public class FailureSubmision
    {
        public FailureSubmision()
        {
            FailOccurrences = new List<FailureOccurrence>();
        }
        
        public String ApiToken { get; set; }

        /// <summary>                
        ///    ASPNET 
        ///    Ruby
        ///    Django 
        ///    Java 
        ///    PHP 
        ///    JavaScript         
        /// </summary>
        public String ApplicationType { get; set; }
        
        public String ModuleVersion { get; set; }
        
        public List<FailureOccurrence> FailOccurrences { get; set; }
    }


}
