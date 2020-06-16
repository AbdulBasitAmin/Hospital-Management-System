using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {




            // TODO: This line of code loads data into the 'hospitalmanagment_systemDataSet1.designation' table. You can move, or remove it, as needed.
            this.designationTableAdapter.Fill(this.hospitalmanagment_systemDataSet1.designation);
            // TODO: This line of code loads data into the 'hospitalmanagment_systemDataSet.Departmentt' table. You can move, or remove it, as needed.
            this.departmenttTableAdapter.Fill(this.hospitalmanagment_systemDataSet.Departmentt);

        }
    }
}
