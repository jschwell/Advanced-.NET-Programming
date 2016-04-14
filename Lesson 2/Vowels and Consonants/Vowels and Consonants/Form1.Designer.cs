namespace Vowels_and_Consonants
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
            this.txtWords = new System.Windows.Forms.TextBox();
            this.lblVowelsCaption = new System.Windows.Forms.Label();
            this.lblConsonantsCaption = new System.Windows.Forms.Label();
            this.lblVowels = new System.Windows.Forms.Label();
            this.lblConsonants = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpWords = new System.Windows.Forms.GroupBox();
            this.grpCounts = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpWords.SuspendLayout();
            this.grpCounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(6, 19);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(188, 67);
            this.txtWords.TabIndex = 0;
            // 
            // lblVowelsCaption
            // 
            this.lblVowelsCaption.AutoSize = true;
            this.lblVowelsCaption.Location = new System.Drawing.Point(44, 32);
            this.lblVowelsCaption.Name = "lblVowelsCaption";
            this.lblVowelsCaption.Size = new System.Drawing.Size(44, 13);
            this.lblVowelsCaption.TabIndex = 2;
            this.lblVowelsCaption.Text = "Vowels:";
            // 
            // lblConsonantsCaption
            // 
            this.lblConsonantsCaption.AutoSize = true;
            this.lblConsonantsCaption.Location = new System.Drawing.Point(22, 64);
            this.lblConsonantsCaption.Name = "lblConsonantsCaption";
            this.lblConsonantsCaption.Size = new System.Drawing.Size(66, 13);
            this.lblConsonantsCaption.TabIndex = 3;
            this.lblConsonantsCaption.Text = "Consonants:";
            // 
            // lblVowels
            // 
            this.lblVowels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVowels.Location = new System.Drawing.Point(94, 27);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(60, 23);
            this.lblVowels.TabIndex = 4;
            this.lblVowels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConsonants
            // 
            this.lblConsonants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConsonants.Location = new System.Drawing.Point(94, 59);
            this.lblConsonants.Name = "lblConsonants";
            this.lblConsonants.Size = new System.Drawing.Size(60, 23);
            this.lblConsonants.TabIndex = 5;
            this.lblConsonants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(96, 126);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(258, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpWords
            // 
            this.grpWords.Controls.Add(this.txtWords);
            this.grpWords.Location = new System.Drawing.Point(12, 12);
            this.grpWords.Name = "grpWords";
            this.grpWords.Size = new System.Drawing.Size(200, 100);
            this.grpWords.TabIndex = 0;
            this.grpWords.TabStop = false;
            this.grpWords.Text = "Enter a word or sentence";
            // 
            // grpCounts
            // 
            this.grpCounts.Controls.Add(this.lblVowels);
            this.grpCounts.Controls.Add(this.lblVowelsCaption);
            this.grpCounts.Controls.Add(this.lblConsonantsCaption);
            this.grpCounts.Controls.Add(this.lblConsonants);
            this.grpCounts.Location = new System.Drawing.Point(218, 12);
            this.grpCounts.Name = "grpCounts";
            this.grpCounts.Size = new System.Drawing.Size(200, 100);
            this.grpCounts.TabIndex = 4;
            this.grpCounts.TabStop = false;
            this.grpCounts.Text = "Number of Vowels and Consonants";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(431, 162);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpCounts);
            this.Controls.Add(this.grpWords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Vowels and Consonants";
            this.grpWords.ResumeLayout(false);
            this.grpWords.PerformLayout();
            this.grpCounts.ResumeLayout(false);
            this.grpCounts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label lblConsonants;
        private System.Windows.Forms.Label lblVowels;
        private System.Windows.Forms.Label lblConsonantsCaption;
        private System.Windows.Forms.Label lblVowelsCaption;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpWords;
        private System.Windows.Forms.GroupBox grpCounts;
        private System.Windows.Forms.Button btnClear;
    }
}

