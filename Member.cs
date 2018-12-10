using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaimlerProject
{
    public class Member
    {
        private string name;
        public string Status { get; set; }
        public String Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length > 0)
                {
                    this.name = value;
                    Status = "valid";
                }
                else
                {
                    this.name = null;
                    Status = "invalid";
                }
            }
        }



    }
}
