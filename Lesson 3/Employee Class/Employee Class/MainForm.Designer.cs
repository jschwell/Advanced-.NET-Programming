namespace Employee_Class
{
    partial class MainForm
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
            this.grpEmployeeData = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpEmployees = new System.Windows.Forms.GroupBox();
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpEmployeeData.SuspendLayout();
            this.grpEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeData
            // 
            this.grpEmployeeData.Controls.Add(this.btnAdd);
            this.grpEmployeeData.Controls.Add(this.txtDepartment);
            this.grpEmployeeData.Controls.Add(this.txtId);
            this.grpEmployeeData.Controls.Add(this.txtName);
            this.grpEmployeeData.Controls.Add(this.txtPosition);
            this.grpEmployeeData.Controls.Add(this.lblPosition);
            this.grpEmployeeData.Controls.Add(this.lblDepartment);
            this.grpEmployeeData.Controls.Add(this.lblId);
            this.grpEmployeeData.Controls.Add(this.lblName);
            this.grpEmployeeData.Location = new System.Drawing.Point(12, 12);
            this.grpEmployeeData.Name = "grpEmployeeData";
            this.grpEmployeeData.Size = new System.Drawing.Size(228, 189);
            this.grpEmployeeData.TabIndex = 0;
            this.grpEmployeeData.TabStop = false;
            this.grpEmployeeData.Text = "Add an Employee";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(89, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(89, 79);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(123, 20);
            this.txtDepartment.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(123, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(89, 105);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(123, 20);
            this.txtPosition.TabIndex = 3;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(39, 108);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(21, 82);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grpEmployees
            // 
            this.grpEmployees.Controls.Add(this.lbEmployee);
            this.grpEmployees.Location = new System.Drawing.Point(12, 207);
            this.grpEmployees.Name = "grpEmployees";
            this.grpEmployees.Size = new System.Drawing.Size(228, 172);
            this.grpEmployees.TabIndex = 1;
            this.grpEmployees.TabStop = false;
            this.grpEmployees.Text = "Employees";
            // 
            // lbEmployee
            // 
            this.lbEmployee.FormattingEnabled = true;
            this.lbEmployee.Location = new System.Drawing.Point(17, 23);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(195, 134);
            this.lbEmployee.TabIndex = 0;
            this.lbEmployee.SelectedIndexChanged += new System.EventHandler(this.lbEmployee_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(89, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(253, 434);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpEmployees);
            this.Controls.Add(this.grpEmployeeData);
            this.Name = "MainForm";
            this.Text = "Employee Class";
            this.grpEmployeeData.ResumeLayout(false);
            this.grpEmployeeData.PerformLayout();
            this.grpEmployees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeData;
        private System.Windows.Forms.GroupBox grpEmployees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbEmployee;
        private System.Windows.Forms.Button btnExit;
    }
}

