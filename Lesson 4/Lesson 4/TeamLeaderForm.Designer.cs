namespace Lesson_4
{
    partial class TeamLeaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.grpTeamLeaderList = new System.Windows.Forms.GroupBox();
            this.lbTeamLeaders = new System.Windows.Forms.ListBox();
            this.grpAddEmp = new System.Windows.Forms.GroupBox();
            this.pnlShift = new System.Windows.Forms.Panel();
            this.rbShift2 = new System.Windows.Forms.RadioButton();
            this.rbShift1 = new System.Windows.Forms.RadioButton();
            this.txtAttendedHours = new System.Windows.Forms.TextBox();
            this.txtRequiredHours = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblAttendedHours = new System.Windows.Forms.Label();
            this.lblRequiredHours = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHourlyPayRate = new System.Windows.Forms.Label();
            this.lblShiftNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpTeamLeaderList.SuspendLayout();
            this.grpAddEmp.SuspendLayout();
            this.pnlShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(153, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpTeamLeaderList
            // 
            this.grpTeamLeaderList.Controls.Add(this.lbTeamLeaders);
            this.grpTeamLeaderList.Location = new System.Drawing.Point(12, 290);
            this.grpTeamLeaderList.Name = "grpTeamLeaderList";
            this.grpTeamLeaderList.Size = new System.Drawing.Size(353, 139);
            this.grpTeamLeaderList.TabIndex = 1;
            this.grpTeamLeaderList.TabStop = false;
            this.grpTeamLeaderList.Text = "Team Leaders";
            // 
            // lbTeamLeaders
            // 
            this.lbTeamLeaders.FormattingEnabled = true;
            this.lbTeamLeaders.Location = new System.Drawing.Point(16, 19);
            this.lbTeamLeaders.Name = "lbTeamLeaders";
            this.lbTeamLeaders.Size = new System.Drawing.Size(320, 108);
            this.lbTeamLeaders.TabIndex = 0;
            this.lbTeamLeaders.SelectedIndexChanged += new System.EventHandler(this.lbTeamLeaders_SelectedIndexChanged);
            // 
            // grpAddEmp
            // 
            this.grpAddEmp.Controls.Add(this.pnlShift);
            this.grpAddEmp.Controls.Add(this.txtAttendedHours);
            this.grpAddEmp.Controls.Add(this.txtRequiredHours);
            this.grpAddEmp.Controls.Add(this.txtBonus);
            this.grpAddEmp.Controls.Add(this.lblAttendedHours);
            this.grpAddEmp.Controls.Add(this.lblRequiredHours);
            this.grpAddEmp.Controls.Add(this.lblBonus);
            this.grpAddEmp.Controls.Add(this.txtHourlyPayRate);
            this.grpAddEmp.Controls.Add(this.btnAddEmp);
            this.grpAddEmp.Controls.Add(this.txtNumber);
            this.grpAddEmp.Controls.Add(this.txtName);
            this.grpAddEmp.Controls.Add(this.lblHourlyPayRate);
            this.grpAddEmp.Controls.Add(this.lblShiftNumber);
            this.grpAddEmp.Controls.Add(this.lblNumber);
            this.grpAddEmp.Controls.Add(this.lblName);
            this.grpAddEmp.Location = new System.Drawing.Point(12, 12);
            this.grpAddEmp.Name = "grpAddEmp";
            this.grpAddEmp.Size = new System.Drawing.Size(353, 272);
            this.grpAddEmp.TabIndex = 0;
            this.grpAddEmp.TabStop = false;
            this.grpAddEmp.Text = "Add a Team Leader";
            // 
            // pnlShift
            // 
            this.pnlShift.Controls.Add(this.rbShift2);
            this.pnlShift.Controls.Add(this.rbShift1);
            this.pnlShift.Location = new System.Drawing.Point(159, 75);
            this.pnlShift.Name = "pnlShift";
            this.pnlShift.Size = new System.Drawing.Size(117, 49);
            this.pnlShift.TabIndex = 2;
            // 
            // rbShift2
            // 
            this.rbShift2.AutoSize = true;
            this.rbShift2.Location = new System.Drawing.Point(3, 26);
            this.rbShift2.Name = "rbShift2";
            this.rbShift2.Size = new System.Drawing.Size(31, 17);
            this.rbShift2.TabIndex = 1;
            this.rbShift2.Text = "2";
            this.rbShift2.UseVisualStyleBackColor = true;
            // 
            // rbShift1
            // 
            this.rbShift1.AutoSize = true;
            this.rbShift1.Checked = true;
            this.rbShift1.Location = new System.Drawing.Point(3, 3);
            this.rbShift1.Name = "rbShift1";
            this.rbShift1.Size = new System.Drawing.Size(31, 17);
            this.rbShift1.TabIndex = 0;
            this.rbShift1.TabStop = true;
            this.rbShift1.Text = "1";
            this.rbShift1.UseVisualStyleBackColor = true;
            // 
            // txtAttendedHours
            // 
            this.txtAttendedHours.Location = new System.Drawing.Point(159, 208);
            this.txtAttendedHours.Name = "txtAttendedHours";
            this.txtAttendedHours.Size = new System.Drawing.Size(117, 20);
            this.txtAttendedHours.TabIndex = 6;
            // 
            // txtRequiredHours
            // 
            this.txtRequiredHours.Location = new System.Drawing.Point(159, 182);
            this.txtRequiredHours.Name = "txtRequiredHours";
            this.txtRequiredHours.Size = new System.Drawing.Size(117, 20);
            this.txtRequiredHours.TabIndex = 5;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(159, 156);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(117, 20);
            this.txtBonus.TabIndex = 4;
            // 
            // lblAttendedHours
            // 
            this.lblAttendedHours.AutoSize = true;
            this.lblAttendedHours.Location = new System.Drawing.Point(31, 211);
            this.lblAttendedHours.Name = "lblAttendedHours";
            this.lblAttendedHours.Size = new System.Drawing.Size(122, 13);
            this.lblAttendedHours.TabIndex = 9;
            this.lblAttendedHours.Text = "Training Hours Attended";
            // 
            // lblRequiredHours
            // 
            this.lblRequiredHours.AutoSize = true;
            this.lblRequiredHours.Location = new System.Drawing.Point(31, 185);
            this.lblRequiredHours.Name = "lblRequiredHours";
            this.lblRequiredHours.Size = new System.Drawing.Size(122, 13);
            this.lblRequiredHours.TabIndex = 7;
            this.lblRequiredHours.Text = "Required Training Hours";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(76, 159);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(77, 13);
            this.lblBonus.TabIndex = 5;
            this.lblBonus.Text = "Monthly Bonus";
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Location = new System.Drawing.Point(159, 130);
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(117, 20);
            this.txtHourlyPayRate.TabIndex = 3;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(159, 234);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(117, 23);
            this.btnAddEmp.TabIndex = 7;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(159, 49);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(117, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblHourlyPayRate
            // 
            this.lblHourlyPayRate.AutoSize = true;
            this.lblHourlyPayRate.Location = new System.Drawing.Point(69, 133);
            this.lblHourlyPayRate.Name = "lblHourlyPayRate";
            this.lblHourlyPayRate.Size = new System.Drawing.Size(84, 13);
            this.lblHourlyPayRate.TabIndex = 3;
            this.lblHourlyPayRate.Text = "Hourly Pay Rate";
            // 
            // lblShiftNumber
            // 
            this.lblShiftNumber.AutoSize = true;
            this.lblShiftNumber.Location = new System.Drawing.Point(85, 78);
            this.lblShiftNumber.Name = "lblShiftNumber";
            this.lblShiftNumber.Size = new System.Drawing.Size(68, 13);
            this.lblShiftNumber.TabIndex = 2;
            this.lblShiftNumber.Text = "Shift Number";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(60, 52);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(93, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Employee Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name";
            // 
            // TeamLeaderForm
            // 
            this.AcceptButton = this.btnAddEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(377, 493);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpTeamLeaderList);
            this.Controls.Add(this.grpAddEmp);
            this.Name = "TeamLeaderForm";
            this.Text = "TeamLeader Class";
            this.grpTeamLeaderList.ResumeLayout(false);
            this.grpAddEmp.ResumeLayout(false);
            this.grpAddEmp.PerformLayout();
            this.pnlShift.ResumeLayout(false);
            this.pnlShift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpTeamLeaderList;
        private System.Windows.Forms.ListBox lbTeamLeaders;
        private System.Windows.Forms.GroupBox grpAddEmp;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHourlyPayRate;
        private System.Windows.Forms.Label lblShiftNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAttendedHours;
        private System.Windows.Forms.TextBox txtRequiredHours;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblAttendedHours;
        private System.Windows.Forms.Label lblRequiredHours;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Panel pnlShift;
        private System.Windows.Forms.RadioButton rbShift2;
        private System.Windows.Forms.RadioButton rbShift1;
    }
}