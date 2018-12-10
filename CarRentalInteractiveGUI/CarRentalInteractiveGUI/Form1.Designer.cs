namespace CarRentalInteractiveGUI
{
    partial class lblDays
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
            this.lblMiles = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtdaysRented = new System.Windows.Forms.TextBox();
            this.txtmilesUsed = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the amount of days the car was rented";
            this.label1.UseWaitCursor = true;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Location = new System.Drawing.Point(31, 136);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(270, 24);
            this.lblMiles.TabIndex = 1;
            this.lblMiles.Text = "Enter the amount of miles used";
            this.lblMiles.UseWaitCursor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 197);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 45);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Total Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtdaysRented
            // 
            this.txtdaysRented.Location = new System.Drawing.Point(430, 49);
            this.txtdaysRented.Name = "txtdaysRented";
            this.txtdaysRented.Size = new System.Drawing.Size(100, 20);
            this.txtdaysRented.TabIndex = 3;
            // 
            // txtmilesUsed
            // 
            this.txtmilesUsed.Location = new System.Drawing.Point(321, 140);
            this.txtmilesUsed.Name = "txtmilesUsed";
            this.txtmilesUsed.Size = new System.Drawing.Size(100, 20);
            this.txtmilesUsed.TabIndex = 4;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(202, 197);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(161, 28);
            this.lblTotalCost.TabIndex = 5;
            // 
            // lblDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtmilesUsed);
            this.Controls.Add(this.txtdaysRented);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.label1);
            this.Name = "lblDays";
            this.Text = "Car Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtdaysRented;
        private System.Windows.Forms.TextBox txtmilesUsed;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

