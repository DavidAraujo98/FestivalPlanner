using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Band
    {
        public int id { get; set; }
        public string name { get; set; }
        public int telephone { get; set; }
        public string email { get; set; }
        public string genre { get; set; }
        public Group group { get; set; }

        public Band(int id=0, string name="", int telephone=0, string email="", string genre="", Group group=null)
        {
            this.id = id;
            this.name = name;
            this.telephone = telephone;
            this.email = email;
            this.genre = genre;
            this.group = group;
        }
    }
}
