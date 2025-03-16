namespace average_marksCalculator
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
            this.btn_average = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_average = new System.Windows.Forms.Label();
            this.tb_physics = new System.Windows.Forms.TextBox();
            this.tb_maths = new System.Windows.Forms.TextBox();
            this.tb_history = new System.Windows.Forms.TextBox();
            this.tb_sociology = new System.Windows.Forms.TextBox();
            this.tb_chemistry = new System.Windows.Forms.TextBox();
            this.tb_average = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_average
            // 
            this.btn_average.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_average.Location = new System.Drawing.Point(647, 180);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(110, 45);
            this.btn_average.TabIndex = 0;
            this.btn_average.Text = "AVERAGE";
            this.btn_average.UseVisualStyleBackColor = false;
            this.btn_average.Click += new System.EventHandler(this.btn_average_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Physics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maths";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "History";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sociology";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chemistry";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_average
            // 
            this.lbl_average.AutoSize = true;
            this.lbl_average.Location = new System.Drawing.Point(111, 307);
            this.lbl_average.Name = "lbl_average";
            this.lbl_average.Size = new System.Drawing.Size(68, 20);
            this.lbl_average.TabIndex = 6;
            this.lbl_average.Text = "Average";
            // 
            // tb_physics
            // 
            this.tb_physics.Location = new System.Drawing.Point(288, 70);
            this.tb_physics.Name = "tb_physics";
            this.tb_physics.Size = new System.Drawing.Size(100, 26);
            this.tb_physics.TabIndex = 7;
            // 
            // tb_maths
            // 
            this.tb_maths.Location = new System.Drawing.Point(288, 109);
            this.tb_maths.Name = "tb_maths";
            this.tb_maths.Size = new System.Drawing.Size(100, 26);
            this.tb_maths.TabIndex = 9;
            // 
            // tb_history
            // 
            this.tb_history.Location = new System.Drawing.Point(288, 147);
            this.tb_history.Name = "tb_history";
            this.tb_history.Size = new System.Drawing.Size(100, 26);
            this.tb_history.TabIndex = 10;
            // 
            // tb_sociology
            // 
            this.tb_sociology.Location = new System.Drawing.Point(288, 189);
            this.tb_sociology.Name = "tb_sociology";
            this.tb_sociology.Size = new System.Drawing.Size(100, 26);
            this.tb_sociology.TabIndex = 11;
            // 
            // tb_chemistry
            // 
            this.tb_chemistry.Location = new System.Drawing.Point(288, 233);
            this.tb_chemistry.Name = "tb_chemistry";
            this.tb_chemistry.Size = new System.Drawing.Size(100, 26);
            this.tb_chemistry.TabIndex = 12;
            // 
            // tb_average
            // 
            this.tb_average.Location = new System.Drawing.Point(288, 307);
            this.tb_average.Name = "tb_average";
            this.tb_average.Size = new System.Drawing.Size(100, 26);
            this.tb_average.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_average);
            this.Controls.Add(this.tb_chemistry);
            this.Controls.Add(this.tb_sociology);
            this.Controls.Add(this.tb_history);
            this.Controls.Add(this.tb_maths);
            this.Controls.Add(this.tb_physics);
            this.Controls.Add(this.lbl_average);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_average);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_average;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_average;
        private System.Windows.Forms.TextBox tb_physics;
        private System.Windows.Forms.TextBox tb_maths;
        private System.Windows.Forms.TextBox tb_history;
        private System.Windows.Forms.TextBox tb_sociology;
        private System.Windows.Forms.TextBox tb_chemistry;
        private System.Windows.Forms.TextBox tb_average;
    }
}

