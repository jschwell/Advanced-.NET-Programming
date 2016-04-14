namespace Lesson_4
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
            this.btnProblem1 = new System.Windows.Forms.Button();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.btnProblem3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProblem1
            // 
            this.btnProblem1.Location = new System.Drawing.Point(12, 29);
            this.btnProblem1.Name = "btnProblem1";
            this.btnProblem1.Size = new System.Drawing.Size(75, 37);
            this.btnProblem1.TabIndex = 0;
            this.btnProblem1.Text = "Problem 1";
            this.btnProblem1.UseVisualStyleBackColor = true;
            this.btnProblem1.Click += new System.EventHandler(this.btnProblem1_Click);
            // 
            // btnProblem2
            // 
            this.btnProblem2.Location = new System.Drawing.Point(93, 29);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(75, 37);
            this.btnProblem2.TabIndex = 1;
            this.btnProblem2.Text = "Problem 2";
            this.btnProblem2.UseVisualStyleBackColor = true;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // btnProblem3
            // 
            this.btnProblem3.Location = new System.Drawing.Point(174, 29);
            this.btnProblem3.Name = "btnProblem3";
            this.btnProblem3.Size = new System.Drawing.Size(75, 37);
            this.btnProblem3.TabIndex = 2;
            this.btnProblem3.Text = "Problem 3";
            this.btnProblem3.UseVisualStyleBackColor = true;
            this.btnProblem3.Click += new System.EventHandler(this.btnProblem3_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(93, 91);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(261, 150);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProblem3);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.btnProblem1);
            this.Name = "MainForm";
            this.Text = "Select a Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProblem1;
        private System.Windows.Forms.Button btnProblem2;
        private System.Windows.Forms.Button btnProblem3;
        private System.Windows.Forms.Button btnExit;
    }
}

