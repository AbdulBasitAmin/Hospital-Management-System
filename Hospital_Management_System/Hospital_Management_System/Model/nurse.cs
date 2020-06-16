using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Model
{
    class nurse:employee,department
    {
        public int dept_id { get; set; }

        public int dept_name { get; set; }
        public int nurse_id { get; set; }
    }

}
