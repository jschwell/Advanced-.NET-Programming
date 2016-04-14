namespace Alphabetic_Telephone_Number
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpTranslate = new System.Windows.Forms.GroupBox();
            this.grpTranslated = new System.Windows.Forms.GroupBox();
            this.lblTranslated = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpTranslate.SuspendLayout();
            this.grpTranslated.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(55, 45);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(176, 20);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(184, 124);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(346, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpTranslate
            // 
            this.grpTranslate.Controls.Add(this.txtPhoneNumber);
            this.grpTranslate.Location = new System.Drawing.Point(12, 12);
            this.grpTranslate.Name = "grpTranslate";
            this.grpTranslate.Size = new System.Drawing.Size(289, 100);
            this.grpTranslate.TabIndex = 0;
            this.grpTranslate.TabStop = false;
            this.grpTranslate.Text = "Enter a phone number in the format XXX-XXX-XXXX";
            // 
            // grpTranslated
            // 
            this.grpTranslated.Controls.Add(this.lblTranslated);
            this.grpTranslated.Location = new System.Drawing.Point(307, 12);
            this.grpTranslated.Name = "grpTranslated";
            this.grpTranslated.Size = new System.Drawing.Size(289, 100);
            this.grpTranslated.TabIndex = 4;
            this.grpTranslated.TabStop = false;
            this.grpTranslated.Text = "Translated phone number";
            // 
            // lblTranslated
            // 
            this.lblTranslated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTranslated.Location = new System.Drawing.Point(58, 44);
            this.lblTranslated.Name = "lblTranslated";
            this.lblTranslated.Size = new System.Drawing.Size(176, 20);
            this.lblTranslated.TabIndex = 0;
            this.lblTranslated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(265, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTranslate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(609, 159);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpTranslated);
            this.Controls.Add(this.grpTranslate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTranslate);
            this.Name = "Form1";
            this.Text = "Alphabetic Telephone Number Translator";
            this.grpTranslate.ResumeLayout(false);
            this.grpTranslate.PerformLayout();
            this.grpTranslated.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpTranslate;
        private System.Windows.Forms.GroupBox grpTranslated;
        private System.Windows.Forms.Label lblTranslated;
        private System.Windows.Forms.Button btnClear;
    }
}

