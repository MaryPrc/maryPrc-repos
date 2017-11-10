using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlintaTest
{
    public class Actor
    {
        public string Name { get; set; }
        public List<Role> ActorsRoles { get; set; }

        public  Actor(){
            ActorsRoles = new List<Role>();
        }


    }
}
