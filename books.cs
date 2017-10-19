using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weblab1Forms
{

    class books
    {
        
        public int id { get; set; }
        public string name { get; set; }

        public string description { get; set; }
        public int year { get; set; }

        public byte[] myimage { get; set; }
    }
}
