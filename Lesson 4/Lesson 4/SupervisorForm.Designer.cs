namespace Lesson_4
{
    partial class SupervisorForm
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
            this.grpSupervisorList = new System.Windows.Forms.GroupBox();
            this.lbSupervisors = new System.Windows.Forms.ListBox();
            this.grpAddEmp = new System.Windows.Forms.GroupBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpSupervisorList.SuspendLayout();
            this.grpAddEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(153, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpSupervisorList
            // 
            this.grpSupervisorList.Controls.Add(this.lbSupervisors);
            this.grpSupervisorList.Location = new System.Drawing.Point(12, 186);
            this.grpSupervisorList.Name = "grpSupervisorList";
            this.grpSupervisorList.Size = new System.Drawing.Size(353, 139);
            this.grpSupervisorList.TabIndex = 1;
            this.grpSupervisorList.TabStop = false;
            this.grpSupervisorList.Text = "Shift Supervisors";
            // 
            // lbSupervisors
            // 
            this.lbSupervisors.FormattingEnabled = true;
            this.lbSupervisors.Location = new System.Drawing.Point(16, 19);
            this.lbSupervisors.Name = "lbSupervisors";
            this.lbSupervisors.Size = new System.Drawing.Size(320, 108);
            this.lbSupervisors.TabIndex = 0;
            this.lbSupervisors.SelectedIndexChanged += new System.EventHandler(this.lbSupervisors_SelectedIndexChanged);
            // 
            // grpAddEmp
            // 
            this.grpAddEmp.Controls.Add(this.txtBonus);
            this.grpAddEmp.Controls.Add(this.btnAddEmp);
            this.grpAddEmp.Controls.Add(this.txtSalary);
            this.grpAddEmp.Controls.Add(this.txtNumber);
            this.grpAddEmp.Controls.Add(this.txtName);
            this.grpAddEmp.Controls.Add(this.lblBonus);
            this.grpAddEmp.Controls.Add(this.lblSalary);
            this.grpAddEmp.Controls.Add(this.lblNumber);
            this.grpAddEmp.Controls.Add(this.lblName);
            this.grpAddEmp.Location = new System.Drawing.Point(12, 12);
            this.grpAddEmp.Name = "grpAddEmp";
            this.grpAddEmp.Size = new System.Drawing.Size(353, 168);
            this.grpAddEmp.TabIndex = 0;
            this.grpAddEmp.TabStop = false;
            this.grpAddEmp.Text = "Add a Shift Supervisor";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(155, 101);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(117, 20);
            this.txtBonus.TabIndex = 3;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(155, 127);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(117, 23);
            this.btnAddEmp.TabIndex = 4;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(155, 75);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(117, 20);
            this.txtSalary.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(155, 49);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(117, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(76, 104);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(73, 13);
            this.lblBonus.TabIndex = 3;
            this.lblBonus.Text = "Annual Bonus";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(77, 78);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(72, 13);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Annual Salary";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(56, 52);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(93, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Employee Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Employee Name";
            // 
            // SupervisorForm
            // 
            this.AcceptButton = this.btnAddEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(377, 393);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpSupervisorList);
            this.Controls.Add(this.grpAddEmp);
            this.Name = "SupervisorForm";
            this.Text = "ShiftSupervisor Class";
            this.grpSupervisorList.ResumeLayout(false);
            this.grpAddEmp.ResumeLayout(false);
            this.grpAddEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpSupervisorList;
        private System.Windows.Forms.ListBox lbSupervisors;
        private System.Windows.Forms.GroupBox grpAddEmp;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
    }
}