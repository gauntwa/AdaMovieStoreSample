using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaMovieStoreSample.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Registered_At { get; set; }
        public string address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal_Code { get; set; }
        public string Phone { get; set; }
        public string Account_Credit { get; set; }

    }
}
