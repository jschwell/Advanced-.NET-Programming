namespace Dorm_and_Meal_Plan
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
            this.grpDorms = new System.Windows.Forms.GroupBox();
            this.rbUniversitySuites = new System.Windows.Forms.RadioButton();
            this.rbFarthingHall = new System.Windows.Forms.RadioButton();
            this.rbPikeHall = new System.Windows.Forms.RadioButton();
            this.rbAllenHall = new System.Windows.Forms.RadioButton();
            this.grpMealPlan = new System.Windows.Forms.GroupBox();
            this.rbUnlimitedMeals = new System.Windows.Forms.RadioButton();
            this.rb14Meals = new System.Windows.Forms.RadioButton();
            this.rb7Meals = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDorms.SuspendLayout();
            this.grpMealPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDorms
            // 
            this.grpDorms.Controls.Add(this.rbUniversitySuites);
            this.grpDorms.Controls.Add(this.rbFarthingHall);
            this.grpDorms.Controls.Add(this.rbPikeHall);
            this.grpDorms.Controls.Add(this.rbAllenHall);
            this.grpDorms.Location = new System.Drawing.Point(12, 12);
            this.grpDorms.Name = "grpDorms";
            this.grpDorms.Size = new System.Drawing.Size(200, 126);
            this.grpDorms.TabIndex = 0;
            this.grpDorms.TabStop = false;
            this.grpDorms.Text = "Choose a Dorm";
            // 
            // rbUniversitySuites
            // 
            this.rbUniversitySuites.AutoSize = true;
            this.rbUniversitySuites.Location = new System.Drawing.Point(57, 92);
            this.rbUniversitySuites.Name = "rbUniversitySuites";
            this.rbUniversitySuites.Size = new System.Drawing.Size(103, 17);
            this.rbUniversitySuites.TabIndex = 3;
            this.rbUniversitySuites.Text = "University Suites";
            this.rbUniversitySuites.UseVisualStyleBackColor = true;
            // 
            // rbFarthingHall
            // 
            this.rbFarthingHall.AutoSize = true;
            this.rbFarthingHall.Location = new System.Drawing.Point(57, 69);
            this.rbFarthingHall.Name = "rbFarthingHall";
            this.rbFarthingHall.Size = new System.Drawing.Size(84, 17);
            this.rbFarthingHall.TabIndex = 2;
            this.rbFarthingHall.Text = "Farthing Hall";
            this.rbFarthingHall.UseVisualStyleBackColor = true;
            // 
            // rbPikeHall
            // 
            this.rbPikeHall.AutoSize = true;
            this.rbPikeHall.Location = new System.Drawing.Point(57, 46);
            this.rbPikeHall.Name = "rbPikeHall";
            this.rbPikeHall.Size = new System.Drawing.Size(67, 17);
            this.rbPikeHall.TabIndex = 1;
            this.rbPikeHall.Text = "Pike Hall";
            this.rbPikeHall.UseVisualStyleBackColor = true;
            // 
            // rbAllenHall
            // 
            this.rbAllenHall.AutoSize = true;
            this.rbAllenHall.Checked = true;
            this.rbAllenHall.Location = new System.Drawing.Point(57, 23);
            this.rbAllenHall.Name = "rbAllenHall";
            this.rbAllenHall.Size = new System.Drawing.Size(69, 17);
            this.rbAllenHall.TabIndex = 0;
            this.rbAllenHall.TabStop = true;
            this.rbAllenHall.Text = "Allen Hall";
            this.rbAllenHall.UseVisualStyleBackColor = true;
            // 
            // grpMealPlan
            // 
            this.grpMealPlan.Controls.Add(this.rbUnlimitedMeals);
            this.grpMealPlan.Controls.Add(this.rb14Meals);
            this.grpMealPlan.Controls.Add(this.rb7Meals);
            this.grpMealPlan.Location = new System.Drawing.Point(218, 12);
            this.grpMealPlan.Name = "grpMealPlan";
            this.grpMealPlan.Size = new System.Drawing.Size(200, 126);
            this.grpMealPlan.TabIndex = 1;
            this.grpMealPlan.TabStop = false;
            this.grpMealPlan.Text = "Choose a Meal Plan";
            // 
            // rbUnlimitedMeals
            // 
            this.rbUnlimitedMeals.AutoSize = true;
            this.rbUnlimitedMeals.Location = new System.Drawing.Point(57, 69);
            this.rbUnlimitedMeals.Name = "rbUnlimitedMeals";
            this.rbUnlimitedMeals.Size = new System.Drawing.Size(98, 17);
            this.rbUnlimitedMeals.TabIndex = 2;
            this.rbUnlimitedMeals.Text = "Unlimited meals";
            this.rbUnlimitedMeals.UseVisualStyleBackColor = true;
            // 
            // rb14Meals
            // 
            this.rb14Meals.AutoSize = true;
            this.rb14Meals.Location = new System.Drawing.Point(57, 46);
            this.rb14Meals.Name = "rb14Meals";
            this.rb14Meals.Size = new System.Drawing.Size(114, 17);
            this.rb14Meals.TabIndex = 1;
            this.rb14Meals.Text = "14 meals per week";
            this.rb14Meals.UseVisualStyleBackColor = true;
            // 
            // rb7Meals
            // 
            this.rb7Meals.AutoSize = true;
            this.rb7Meals.Checked = true;
            this.rb7Meals.Location = new System.Drawing.Point(57, 23);
            this.rb7Meals.Name = "rb7Meals";
            this.rb7Meals.Size = new System.Drawing.Size(108, 17);
            this.rb7Meals.TabIndex = 0;
            this.rb7Meals.TabStop = true;
            this.rb7Meals.Text = "7 meals per week";
            this.rb7Meals.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(137, 150);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(218, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(431, 187);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpMealPlan);
            this.Controls.Add(this.grpDorms);
            this.Name = "MainForm";
            this.Text = "Dorm and Meal Plan Calculator";
            this.grpDorms.ResumeLayout(false);
            this.grpDorms.PerformLayout();
            this.grpMealPlan.ResumeLayout(false);
            this.grpMealPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDorms;
        private System.Windows.Forms.RadioButton rbUniversitySuites;
        private System.Windows.Forms.RadioButton rbFarthingHall;
        private System.Windows.Forms.RadioButton rbPikeHall;
        private System.Windows.Forms.RadioButton rbAllenHall;
        private System.Windows.Forms.GroupBox grpMealPlan;
        private System.Windows.Forms.RadioButton rbUnlimitedMeals;
        private System.Windows.Forms.RadioButton rb14Meals;
        private System.Windows.Forms.RadioButton rb7Meals;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

