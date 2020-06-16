using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Model
{
    class insert_class_model
    {

        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;


        public void insert_record(int des)
        {
            string[] biodata = new string[12];
            if (des==1)
            {
                doctor d=new doctor();
                biodata[0] = d.emp_id.ToString();
                biodata[1] = d.EMP_NAME;
                biodata[2] = d.EMP_DOB;
                biodata[3] = d.EMP_CNIC;
                biodata[4] = d.EMP_CONTACT;
                biodata[5] = d.EMP_EMAIL;
                biodata[6] = d.EMP_GENDER;
                biodata[7] = d.EMP_ADDRESS;
                biodata[8] = d.EMP_JOINING_DATE;
                biodata[9] = d.EMP_SALARY.ToString();
                biodata[10] = d.EMP_SHIFT.ToString();
                biodata[11] = d.dept_id.ToString();
                biodata[12] = des.ToString();
                

            }


            if (des == 2)
            {
                nurse d = new nurse();
                biodata[0] = d.emp_id.ToString();
                biodata[1] = d.EMP_NAME;
                biodata[2] = d.EMP_DOB;
                biodata[3] = d.EMP_CNIC;
                biodata[4] = d.EMP_CONTACT;
                biodata[5] = d.EMP_EMAIL;
                biodata[6] = d.EMP_GENDER;
                biodata[7] = d.EMP_ADDRESS;
                biodata[8] = d.EMP_JOINING_DATE;
                biodata[9] = d.EMP_SALARY.ToString();
                biodata[10] = d.EMP_SHIFT.ToString();
                biodata[11] = d.dept_id.ToString();
                biodata[12] = des.ToString();


            }
            if (des == 3)
            {
                reception d = new reception();
                biodata[0] = d.emp_id.ToString();
                biodata[1] = d.EMP_NAME;
                biodata[2] = d.EMP_DOB;
                biodata[3] = d.EMP_CNIC;
                biodata[4] = d.EMP_CONTACT;
                biodata[5] = d.EMP_EMAIL;
                biodata[6] = d.EMP_GENDER;
                biodata[7] = d.EMP_ADDRESS;
                biodata[8] = d.EMP_JOINING_DATE;
                biodata[9] = d.EMP_SALARY.ToString();
                biodata[10] = d.EMP_SHIFT.ToString();
                biodata[11] = d.dept_id.ToString();
                biodata[12] = des.ToString();


            }


            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT_EMPLOYEE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EMP_NAME", SqlDbType.NVarChar, 50).Value = biodata[1];
                cmd.Parameters.Add("@@EMP_DOB", SqlDbType.NVarChar, 50).Value = biodata[2];
                cmd.Parameters.Add("@@EMP_CNIC", SqlDbType.NVarChar, 50).Value = biodata[3];
                cmd.Parameters.Add("@EMP_CONTACT", SqlDbType.NVarChar, 50).Value = biodata[4];
                cmd.Parameters.Add("@EMP_EMAIL", SqlDbType.NVarChar, 50).Value = biodata[5];
                cmd.Parameters.Add("@EMP_GENDER", SqlDbType.NVarChar, 50).Value = biodata[6];
                cmd.Parameters.Add("@EMP_ADDRESS", SqlDbType.NVarChar, 50).Value = biodata[7];
                cmd.Parameters.Add("@EMP_JOINING_DATE", SqlDbType.NVarChar, 50).Value = biodata[8];
                cmd.Parameters.Add("@EMP_SALARY", SqlDbType.Int).Value = biodata[9];
                cmd.Parameters.Add("@EMP_SHIFT", SqlDbType.Int).Value = biodata[10];
                cmd.Parameters.Add("@dept_id", SqlDbType.Int).Value = biodata[11];
                cmd.Parameters.Add("@desig_id", SqlDbType.Int).Value = biodata[12];

                
                conn.Open();
                cmd.ExecuteNonQuery();


                MessageBox.Show("DATA record has been inserted successfully.....");

            }
            catch (Exception)
            {
                MessageBox.Show("data is not inserted !!!");

            }

            finally
            {
                conn.Close();
            }


        } //method end...........







    }
}
