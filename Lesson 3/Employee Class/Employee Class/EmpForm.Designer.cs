namespace Employee_Class
{
    partial class EmpForm
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeptCaption = new System.Windows.Forms.Label();
            this.lblIdCaption = new System.Windows.Forms.Label();
            this.lblNameCaption = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPositionCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(103, 146);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Location = new System.Drawing.Point(103, 75);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(146, 23);
            this.lblDepartment.TabIndex = 12;
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdNumber.Location = new System.Drawing.Point(103, 47);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(146, 23);
            this.lblIdNumber.TabIndex = 11;
            this.lblIdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(103, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 23);
            this.lblName.TabIndex = 10;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeptCaption
            // 
            this.lblDeptCaption.AutoSize = true;
            this.lblDeptCaption.Location = new System.Drawing.Point(32, 80);
            this.lblDeptCaption.Name = "lblDeptCaption";
            this.lblDeptCaption.Size = new System.Drawing.Size(65, 13);
            this.lblDeptCaption.TabIndex = 9;
            this.lblDeptCaption.Text = "Department:";
            // 
            // lblIdCaption
            // 
            this.lblIdCaption.AutoSize = true;
            this.lblIdCaption.Location = new System.Drawing.Point(36, 52);
            this.lblIdCaption.Name = "lblIdCaption";
            this.lblIdCaption.Size = new System.Drawing.Size(61, 13);
            this.lblIdCaption.TabIndex = 8;
            this.lblIdCaption.Text = "ID Number:";
            // 
            // lblNameCaption
            // 
            this.lblNameCaption.AutoSize = true;
            this.lblNameCaption.Location = new System.Drawing.Point(59, 24);
            this.lblNameCaption.Name = "lblNameCaption";
            this.lblNameCaption.Size = new System.Drawing.Size(38, 13);
            this.lblNameCaption.TabIndex = 7;
            this.lblNameCaption.Text = "Name:";
            // 
            // lblPosition
            // 
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosition.Location = new System.Drawing.Point(103, 103);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(146, 23);
            this.lblPosition.TabIndex = 15;
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPositionCaption
            // 
            this.lblPositionCaption.AutoSize = true;
            this.lblPositionCaption.Location = new System.Drawing.Point(50, 108);
            this.lblPositionCaption.Name = "lblPositionCaption";
            this.lblPositionCaption.Size = new System.Drawing.Size(47, 13);
            this.lblPositionCaption.TabIndex = 14;
            this.lblPositionCaption.Text = "Position:";
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPositionCaption);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblIdNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDeptCaption);
            this.Controls.Add(this.lblIdCaption);
            this.Controls.Add(this.lblNameCaption);
            this.Name = "EmpForm";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.EmpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDeptCaption;
        private System.Windows.Forms.Label lblIdCaption;
        private System.Windows.Forms.Label lblNameCaption;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPositionCaption;
    }
}