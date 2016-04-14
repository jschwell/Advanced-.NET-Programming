using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class EmpForm : Form
    {
        public EmpForm()
        {
            InitializeComponent();
        }

        private void EmpForm_Load(object sender, EventArgs e)
        {
            // Display employee's info in the labels.
            lblName.Text = MainForm.staticName;
            lblIdNumber.Text = MainForm.staticId.ToString();
            lblDepartment.Text = MainForm.staticDept;
            lblPosition.Text = MainForm.staticPosition;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
