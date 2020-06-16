using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Model
{
    class employee
    {
        public int emp_id { get; set; }
        public string EMP_NAME { get; set; }
        public string EMP_DOB { get; set; }
        public string EMP_CNIC { get; set; }
        public string EMP_CONTACT { get; set; }
        public string EMP_EMAIL { get; set; }
        public string EMP_GENDER { get; set; }
        public string EMP_ADDRESS { get; set; }
        public string EMP_JOINING_DATE { get; set; }
        public int EMP_SALARY { get; set; }
        public int EMP_SHIFT { get; set; }




    }

    public interface department
    {
        public int dept_id { get; set; }

        public int dept_name { get; set; }
   }


}
