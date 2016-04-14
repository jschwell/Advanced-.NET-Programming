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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProblem1_Click(object sender, EventArgs e)
        {
            // Create an instance of the WorkerForm class.
            WorkerForm myWorkerForm = new WorkerForm();
            // Display the form.
            myWorkerForm.ShowDialog();
        }
        
        private void btnProblem2_Click(object sender, EventArgs e)
        {
            // Create an instance of the SupervisorForm class.
            SupervisorForm mySupervisorForm = new SupervisorForm();
            // Display the form.
            mySupervisorForm.ShowDialog();
        }

        private void btnProblem3_Click(object sender, EventArgs e)
        {
            // Create an instance of the TeamLeaderForm class.
            TeamLeaderForm myTeamForm = new TeamLeaderForm();
            // Display the form.
            myTeamForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
