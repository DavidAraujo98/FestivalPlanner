using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Person
    {
        public int cc { get; set; }
        public int telephone { get; set; }
        public String name { get; set; }
        public String sex { get; set; }
        public String email { get; set; }

        public Person(int nCC=0, int telephone=0, string name="", string sex="", string email="") : base()
        {
            this.cc = nCC;
            this.telephone = telephone;
            this.name = name;
            this.sex = sex;
            this.email = email;
        }
    }
}
