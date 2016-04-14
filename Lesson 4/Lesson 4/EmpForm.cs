using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_4
{
    public partial class EmpForm : Form
    {
        public EmpForm()
        {
            InitializeComponent();
        }

        // Team Leader Information
        public bool _grpTeamLeader
        {
            set { grpTeamLeader.Visible = value; }
        }

        public string _lblTLName
        {
            set { lblTLName.Text = value; }
        }

        public string _lblTLNumber
        {
            set { lblTLNumber.Text = value; }
        }

        public string _lblTLShift
        {
            set { lblTLShift.Text = value; }
        }

        public string _lblTLPayRate
        {
            set { lblTLPayRate.Text = value; }
        }

        public string _lblTLBonus
        {
            set { lblTLBonus.Text = value; }
        }

        public string _lblTLRequiredHours
        {
            set { lblTLRequiredHours.Text = value; }
        }

        public string _lblTLAttendedHours
        {
            set { lblTLAttendedHours.Text = value; }
        }

        // Shift Supervisor Information
        public bool _grpShiftSupervisor
        {
            set { grpShiftSupervisor.Visible = value; }
        }

        public string _lblSSName
        {
            set { lblSSName.Text = value; }
        }

        public string _lblSSNumber
        {
            set { lblSSNumber.Text = value; }
        }

        public string _lblSSAnnualSalary
        {
            set { lblSSAnnualSalary.Text = value; }
        }

        public string _lblSSBonus
        {
            set { lblSSBonus.Text = value; }
        }

        // Production Worker Information
        public bool _grpProductionWorker
        {
            set { grpProductionWorker.Visible = value; }
        }

        public string _lblPWName
        {
            set { lblPWName.Text = value; }
        }

        public string _lblPWNumber
        {
            set { lblPWNumber.Text = value; }
        }

        public string _lblPWShift
        {
            set { lblPWShift.Text = value; }
        }

        public string _lblPWPayRate
        {
            set { lblPWPayRate.Text = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
