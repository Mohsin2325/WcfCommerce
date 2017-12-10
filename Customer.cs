using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfCommerce
{
    [DataContract (Name ="id")]
    public class Customer
    {
        //private int _id;
        //private string FirstName;
        //private string lastName;
        [DataMember]
        public int ID
        {
            get;set;

        }
        [DataMember (Name ="firstname")]
        public string FirstName
        {
            get; set;

        }
        [DataMember(Name ="lastname")]
        public string LastName
        {
            get; set;

        }
    }
}