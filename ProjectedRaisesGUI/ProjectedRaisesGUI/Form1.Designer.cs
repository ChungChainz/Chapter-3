namespace ProjectedRaisesGUI
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
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblNewYear = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(63, 88);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(303, 24);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Employee\'s current salary here>>>";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(395, 91);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 1;
            // 
            // lblNewYear
            // 
            this.lblNewYear.AutoSize = true;
            this.lblNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewYear.Location = new System.Drawing.Point(63, 205);
            this.lblNewYear.Name = "lblNewYear";
            this.lblNewYear.Size = new System.Drawing.Size(169, 24);
            this.lblNewYear.TabIndex = 2;
            this.lblNewYear.Text = "Salary for next year";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSalary.Location = new System.Drawing.Point(257, 206);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(207, 23);
            this.lblTotalSalary.TabIndex = 3;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(67, 275);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 4;
            this.btnClick.Text = "Click Here";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.lblNewYear);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblCurrent);
            this.Name = "Form1";
            this.Text = "ProjectedRaises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblNewYear;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Button btnClick;
    }
}

