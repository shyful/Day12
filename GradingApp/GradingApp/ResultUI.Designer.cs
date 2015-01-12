namespace GradingApp
{
    partial class ResultUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.physicstextBox = new System.Windows.Forms.TextBox();
            this.mathtextBox = new System.Windows.Forms.TextBox();
            this.ChemistrytextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.averagetextBox = new System.Windows.Forms.TextBox();
            this.gradetextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chemistry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Math";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Out of 100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Out of 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Out of 100";
            // 
            // physicstextBox
            // 
            this.physicstextBox.Location = new System.Drawing.Point(177, 49);
            this.physicstextBox.Name = "physicstextBox";
            this.physicstextBox.Size = new System.Drawing.Size(196, 20);
            this.physicstextBox.TabIndex = 6;
            // 
            // mathtextBox
            // 
            this.mathtextBox.Location = new System.Drawing.Point(177, 150);
            this.mathtextBox.Name = "mathtextBox";
            this.mathtextBox.Size = new System.Drawing.Size(196, 20);
            this.mathtextBox.TabIndex = 7;
            // 
            // ChemistrytextBox
            // 
            this.ChemistrytextBox.Location = new System.Drawing.Point(177, 98);
            this.ChemistrytextBox.Name = "ChemistrytextBox";
            this.ChemistrytextBox.Size = new System.Drawing.Size(196, 20);
            this.ChemistrytextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Average";
            // 
            // averagetextBox
            // 
            this.averagetextBox.Location = new System.Drawing.Point(177, 248);
            this.averagetextBox.Name = "averagetextBox";
            this.averagetextBox.Size = new System.Drawing.Size(137, 20);
            this.averagetextBox.TabIndex = 11;
            // 
            // gradetextBox
            // 
            this.gradetextBox.Location = new System.Drawing.Point(177, 304);
            this.gradetextBox.Name = "gradetextBox";
            this.gradetextBox.Size = new System.Drawing.Size(137, 20);
            this.gradetextBox.TabIndex = 12;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(386, 278);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // ResultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 408);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.gradetextBox);
            this.Controls.Add(this.averagetextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChemistrytextBox);
            this.Controls.Add(this.mathtextBox);
            this.Controls.Add(this.physicstextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ResultUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox physicstextBox;
        private System.Windows.Forms.TextBox mathtextBox;
        private System.Windows.Forms.TextBox ChemistrytextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox averagetextBox;
        private System.Windows.Forms.TextBox gradetextBox;
        private System.Windows.Forms.Button showButton;
    }
}

