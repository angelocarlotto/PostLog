using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace PostLog.AppFailEntitys
{

    public class FailureOccurrence
    {
        public FailureOccurrence()
        {
            Exceptions = new List<Exceptions>();
            PostValuePairs = new List<List<string>>();
            QueryValuePairs = new List<List<string>>();
            ServerVariable = new List<List<string>>();
            Cookies = new List<List<string>>();
        }
        public FailureOccurrence(FailureSubmision parent)
            : this()
        {
            parent.FailOccurrences.Add(this);
        }

        public List<Exceptions> Exceptions { get; set; }

        /// <summary>
        ///    ASPNET 
        ///    Ruby
        ///     Django 
        ///    Java 
        ///    PHP 
        ///    JavaScript 
        /// </summary>
        public String HttpVerb { get; set; }
        public int? HttpStatus { get; set; }
        public String RequestUrl { get; set; }
        public String ReferrerUrl { get; set; }
        public String OccurrenceTimeUtc { get; set; }
        public String User { get; set; }
        public List<List<string>> PostValuePairs { get; set; }
        public List<List<string>> QueryValuePairs { get; set; }
        public List<List<string>> ServerVariable { get; set; }
        public List<List<string>> Cookies { get; set; }
        public String UniqueId { get; set; }
        public String UserAgent { get; set; }
        public String MachineName { get; set; }
    }

}
