namespace Car_Class
{
    partial class Form1
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
            this.grpCarList = new System.Windows.Forms.GroupBox();
            this.lbCarList = new System.Windows.Forms.ListBox();
            this.grpCarData = new System.Windows.Forms.GroupBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSpeedCaption = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.grpSpeed = new System.Windows.Forms.GroupBox();
            this.grpCarList.SuspendLayout();
            this.grpCarData.SuspendLayout();
            this.grpSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarList
            // 
            this.grpCarList.Controls.Add(this.lbCarList);
            this.grpCarList.Location = new System.Drawing.Point(218, 14);
            this.grpCarList.Name = "grpCarList";
            this.grpCarList.Size = new System.Drawing.Size(200, 133);
            this.grpCarList.TabIndex = 1;
            this.grpCarList.TabStop = false;
            this.grpCarList.Text = "Select a Car";
            // 
            // lbCarList
            // 
            this.lbCarList.FormattingEnabled = true;
            this.lbCarList.Location = new System.Drawing.Point(20, 28);
            this.lbCarList.Name = "lbCarList";
            this.lbCarList.Size = new System.Drawing.Size(158, 82);
            this.lbCarList.TabIndex = 0;
            this.lbCarList.SelectedIndexChanged += new System.EventHandler(this.lbCarList_SelectedIndexChanged);
            // 
            // grpCarData
            // 
            this.grpCarData.Controls.Add(this.btnAddCar);
            this.grpCarData.Controls.Add(this.txtYear);
            this.grpCarData.Controls.Add(this.txtMake);
            this.grpCarData.Controls.Add(this.lblYear);
            this.grpCarData.Controls.Add(this.lblMake);
            this.grpCarData.Location = new System.Drawing.Point(12, 12);
            this.grpCarData.Name = "grpCarData";
            this.grpCarData.Size = new System.Drawing.Size(200, 135);
            this.grpCarData.TabIndex = 0;
            this.grpCarData.TabStop = false;
            this.grpCarData.Text = "Enter Car Data";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(65, 96);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(65, 62);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 1;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(65, 29);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(30, 65);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(25, 32);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // lblSpeed
            // 
            this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpeed.Location = new System.Drawing.Point(65, 24);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(100, 23);
            this.lblSpeed.TabIndex = 13;
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeedCaption
            // 
            this.lblSpeedCaption.AutoSize = true;
            this.lblSpeedCaption.Location = new System.Drawing.Point(21, 29);
            this.lblSpeedCaption.Name = "lblSpeedCaption";
            this.lblSpeedCaption.Size = new System.Drawing.Size(38, 13);
            this.lblSpeedCaption.TabIndex = 12;
            this.lblSpeedCaption.Text = "Speed";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(181, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(104, 60);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 23);
            this.btnBrake.TabIndex = 1;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(23, 60);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate.TabIndex = 0;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // grpSpeed
            // 
            this.grpSpeed.Controls.Add(this.lblSpeed);
            this.grpSpeed.Controls.Add(this.btnAccelerate);
            this.grpSpeed.Controls.Add(this.lblSpeedCaption);
            this.grpSpeed.Controls.Add(this.btnBrake);
            this.grpSpeed.Location = new System.Drawing.Point(117, 153);
            this.grpSpeed.Name = "grpSpeed";
            this.grpSpeed.Size = new System.Drawing.Size(200, 100);
            this.grpSpeed.TabIndex = 2;
            this.grpSpeed.TabStop = false;
            this.grpSpeed.Text = "Speed";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddCar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(431, 308);
            this.Controls.Add(this.grpSpeed);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCarList);
            this.Controls.Add(this.grpCarData);
            this.Name = "Form1";
            this.Text = "Car Class";
            this.grpCarList.ResumeLayout(false);
            this.grpCarData.ResumeLayout(false);
            this.grpCarData.PerformLayout();
            this.grpSpeed.ResumeLayout(false);
            this.grpSpeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCarList;
        private System.Windows.Forms.ListBox lbCarList;
        private System.Windows.Forms.GroupBox grpCarData;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSpeedCaption;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.GroupBox grpSpeed;
    }
}

