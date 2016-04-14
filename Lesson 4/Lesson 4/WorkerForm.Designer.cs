namespace Lesson_4
{
    partial class WorkerForm
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
            this.grpAddEmp = new System.Windows.Forms.GroupBox();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHourlyPayRate = new System.Windows.Forms.Label();
            this.lblShiftNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpWorkerList = new System.Windows.Forms.GroupBox();
            this.lbProductionWorkers = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlShift = new System.Windows.Forms.Panel();
            this.rbShift1 = new System.Windows.Forms.RadioButton();
            this.rbShift2 = new System.Windows.Forms.RadioButton();
            this.grpAddEmp.SuspendLayout();
            this.grpWorkerList.SuspendLayout();
            this.pnlShift.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddEmp
            // 
            this.grpAddEmp.Controls.Add(this.pnlShift);
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
            this.grpAddEmp.Size = new System.Drawing.Size(353, 196);
            this.grpAddEmp.TabIndex = 0;
            this.grpAddEmp.TabStop = false;
            this.grpAddEmp.Text = "Add a Production Worker";
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Location = new System.Drawing.Point(155, 130);
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(117, 20);
            this.txtHourlyPayRate.TabIndex = 3;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(155, 156);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(117, 23);
            this.btnAddEmp.TabIndex = 4;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
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
            // lblHourlyPayRate
            // 
            this.lblHourlyPayRate.AutoSize = true;
            this.lblHourlyPayRate.Location = new System.Drawing.Point(65, 133);
            this.lblHourlyPayRate.Name = "lblHourlyPayRate";
            this.lblHourlyPayRate.Size = new System.Drawing.Size(84, 13);
            this.lblHourlyPayRate.TabIndex = 3;
            this.lblHourlyPayRate.Text = "Hourly Pay Rate";
            // 
            // lblShiftNumber
            // 
            this.lblShiftNumber.AutoSize = true;
            this.lblShiftNumber.Location = new System.Drawing.Point(81, 78);
            this.lblShiftNumber.Name = "lblShiftNumber";
            this.lblShiftNumber.Size = new System.Drawing.Size(68, 13);
            this.lblShiftNumber.TabIndex = 2;
            this.lblShiftNumber.Text = "Shift Number";
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
            // grpWorkerList
            // 
            this.grpWorkerList.Controls.Add(this.lbProductionWorkers);
            this.grpWorkerList.Location = new System.Drawing.Point(12, 214);
            this.grpWorkerList.Name = "grpWorkerList";
            this.grpWorkerList.Size = new System.Drawing.Size(353, 139);
            this.grpWorkerList.TabIndex = 1;
            this.grpWorkerList.TabStop = false;
            this.grpWorkerList.Text = "Production Workers";
            // 
            // lbProductionWorkers
            // 
            this.lbProductionWorkers.FormattingEnabled = true;
            this.lbProductionWorkers.Location = new System.Drawing.Point(16, 19);
            this.lbProductionWorkers.Name = "lbProductionWorkers";
            this.lbProductionWorkers.Size = new System.Drawing.Size(320, 108);
            this.lbProductionWorkers.TabIndex = 0;
            this.lbProductionWorkers.SelectedIndexChanged += new System.EventHandler(this.lbProductionWorkers_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(153, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlShift
            // 
            this.pnlShift.Controls.Add(this.rbShift2);
            this.pnlShift.Controls.Add(this.rbShift1);
            this.pnlShift.Location = new System.Drawing.Point(155, 75);
            this.pnlShift.Name = "pnlShift";
            this.pnlShift.Size = new System.Drawing.Size(117, 49);
            this.pnlShift.TabIndex = 2;
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
            // WorkerForm
            // 
            this.AcceptButton = this.btnAddEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(377, 418);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpWorkerList);
            this.Controls.Add(this.grpAddEmp);
            this.Name = "WorkerForm";
            this.Text = "Employee and ProductionWorker Classes";
            this.grpAddEmp.ResumeLayout(false);
            this.grpAddEmp.PerformLayout();
            this.grpWorkerList.ResumeLayout(false);
            this.pnlShift.ResumeLayout(false);
            this.pnlShift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddEmp;
        private System.Windows.Forms.Label lblHourlyPayRate;
        private System.Windows.Forms.Label lblShiftNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpWorkerList;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbProductionWorkers;
        private System.Windows.Forms.Panel pnlShift;
        private System.Windows.Forms.RadioButton rbShift2;
        private System.Windows.Forms.RadioButton rbShift1;
    }
}