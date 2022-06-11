using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Company
    {
        public string email { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public int telephone { get; set; }
        public int NIF { get; set; }

        public Company(string email="", string address="", string name="", int telephone=0, int NIF=0) : base()
        {
            this.email = email;
            this.address = address;
            this.name = name;
            this.telephone = telephone;
            this.NIF = NIF;
        }
    }
}
