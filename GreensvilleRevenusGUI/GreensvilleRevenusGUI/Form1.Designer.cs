namespace GreensvilleRevenusGUI
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
            this.lblnumberLast = new System.Windows.Forms.Label();
            this.lblnumberThis = new System.Windows.Forms.Label();
            this.txtlastYear = new System.Windows.Forms.TextBox();
            this.txtthisYear = new System.Windows.Forms.TextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblthis = new System.Windows.Forms.Label();
            this.lblmoreOrLess = new System.Windows.Forms.Label();
            this.lbllast = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblrevTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnumberLast
            // 
            this.lblnumberLast.AutoSize = true;
            this.lblnumberLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberLast.Location = new System.Drawing.Point(30, 48);
            this.lblnumberLast.Name = "lblnumberLast";
            this.lblnumberLast.Size = new System.Drawing.Size(271, 24);
            this.lblnumberLast.TabIndex = 0;
            this.lblnumberLast.Text = "Number of contestants last year";
            // 
            // lblnumberThis
            // 
            this.lblnumberThis.AutoSize = true;
            this.lblnumberThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberThis.Location = new System.Drawing.Point(30, 117);
            this.lblnumberThis.Name = "lblnumberThis";
            this.lblnumberThis.Size = new System.Drawing.Size(272, 24);
            this.lblnumberThis.TabIndex = 1;
            this.lblnumberThis.Text = "Number of contestants this year";
            // 
            // txtlastYear
            // 
            this.txtlastYear.Location = new System.Drawing.Point(308, 51);
            this.txtlastYear.Name = "txtlastYear";
            this.txtlastYear.Size = new System.Drawing.Size(100, 20);
            this.txtlastYear.TabIndex = 2;
            // 
            // txtthisYear
            // 
            this.txtthisYear.Location = new System.Drawing.Point(308, 117);
            this.txtthisYear.Name = "txtthisYear";
            this.txtthisYear.Size = new System.Drawing.Size(100, 20);
            this.txtthisYear.TabIndex = 3;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(31, 180);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(213, 24);
            this.lblRevenue.TabIndex = 4;
            this.lblRevenue.Text = "This year\'s total revenue";
            // 
            // lblthis
            // 
            this.lblthis.AutoSize = true;
            this.lblthis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthis.Location = new System.Drawing.Point(30, 243);
            this.lblthis.Name = "lblthis";
            this.lblthis.Size = new System.Drawing.Size(308, 24);
            this.lblthis.TabIndex = 6;
            this.lblthis.Text = "This year\'s number of contestants is";
            // 
            // lblmoreOrLess
            // 
            this.lblmoreOrLess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmoreOrLess.Location = new System.Drawing.Point(34, 288);
            this.lblmoreOrLess.Name = "lblmoreOrLess";
            this.lblmoreOrLess.Size = new System.Drawing.Size(304, 23);
            this.lblmoreOrLess.TabIndex = 7;
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllast.Location = new System.Drawing.Point(31, 335);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(286, 24);
            this.lbllast.TabIndex = 8;
            this.lbllast.Text = "last year\'s number of contestants.";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(393, 367);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 60);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblrevTotal
            // 
            this.lblrevTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrevTotal.Location = new System.Drawing.Point(250, 181);
            this.lblrevTotal.Name = "lblrevTotal";
            this.lblrevTotal.Size = new System.Drawing.Size(244, 23);
            this.lblrevTotal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblrevTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.lblmoreOrLess);
            this.Controls.Add(this.lblthis);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.txtthisYear);
            this.Controls.Add(this.txtlastYear);
            this.Controls.Add(this.lblnumberThis);
            this.Controls.Add(this.lblnumberLast);
            this.Name = "Form1";
            this.Text = "Greensville Idol competition revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumberLast;
        private System.Windows.Forms.Label lblnumberThis;
        private System.Windows.Forms.TextBox txtlastYear;
        private System.Windows.Forms.TextBox txtthisYear;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblthis;
        private System.Windows.Forms.Label lblmoreOrLess;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblrevTotal;
    }
}

