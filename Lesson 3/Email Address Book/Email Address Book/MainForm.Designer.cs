﻿namespace Email_Address_Book
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
            this.lbAddressBook = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAddressBook
            // 
            this.lbAddressBook.FormattingEnabled = true;
            this.lbAddressBook.Location = new System.Drawing.Point(12, 12);
            this.lbAddressBook.Name = "lbAddressBook";
            this.lbAddressBook.Size = new System.Drawing.Size(216, 212);
            this.lbAddressBook.TabIndex = 0;
            this.lbAddressBook.SelectedIndexChanged += new System.EventHandler(this.lbAddressBook_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(82, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(241, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbAddressBook);
            this.Name = "MainForm";
            this.Text = "Email Address Book";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAddressBook;
        private System.Windows.Forms.Button btnExit;
    }
}

