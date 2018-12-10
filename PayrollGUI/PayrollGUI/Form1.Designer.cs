namespace PayrollGUI
{
    partial class Payroll
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblhoursWorked = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSecurity = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblFederal = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblgrossTotal = new System.Windows.Forms.Label();
            this.lblfederalTotal = new System.Windows.Forms.Label();
            this.lblstateTotal = new System.Windows.Forms.Label();
            this.lblnetTotal = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Location = new System.Drawing.Point(13, 67);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(117, 13);
            this.lblSecurity.TabIndex = 1;
            this.lblSecurity.Text = "Social Security Number";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(13, 98);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(84, 13);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Hourly Pay Rate";
            // 
            // lblhoursWorked
            // 
            this.lblhoursWorked.AutoSize = true;
            this.lblhoursWorked.Location = new System.Drawing.Point(13, 128);
            this.lblhoursWorked.Name = "lblhoursWorked";
            this.lblhoursWorked.Size = new System.Drawing.Size(128, 13);
            this.lblhoursWorked.TabIndex = 3;
            this.lblhoursWorked.Text = "Number of Hours Worked";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSecurity
            // 
            this.txtSecurity.Location = new System.Drawing.Point(144, 63);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.Size = new System.Drawing.Size(181, 20);
            this.txtSecurity.TabIndex = 5;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(144, 121);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(181, 20);
            this.txtHours.TabIndex = 6;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(144, 91);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(181, 20);
            this.txtRate.TabIndex = 7;
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(35, 196);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(95, 24);
            this.lblGross.TabIndex = 8;
            this.lblGross.Text = "Gross Pay";
            // 
            // lblFederal
            // 
            this.lblFederal.AutoSize = true;
            this.lblFederal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFederal.Location = new System.Drawing.Point(35, 245);
            this.lblFederal.Name = "lblFederal";
            this.lblFederal.Size = new System.Drawing.Size(112, 24);
            this.lblFederal.TabIndex = 9;
            this.lblFederal.Text = "Federal Tax";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(35, 290);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(88, 24);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State Tax";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(35, 337);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(75, 24);
            this.lblNet.TabIndex = 11;
            this.lblNet.Text = "Net Pay";
            // 
            // lblgrossTotal
            // 
            this.lblgrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblgrossTotal.Location = new System.Drawing.Point(163, 197);
            this.lblgrossTotal.Name = "lblgrossTotal";
            this.lblgrossTotal.Size = new System.Drawing.Size(162, 23);
            this.lblgrossTotal.TabIndex = 12;
            // 
            // lblfederalTotal
            // 
            this.lblfederalTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfederalTotal.Location = new System.Drawing.Point(163, 245);
            this.lblfederalTotal.Name = "lblfederalTotal";
            this.lblfederalTotal.Size = new System.Drawing.Size(162, 23);
            this.lblfederalTotal.TabIndex = 13;
            // 
            // lblstateTotal
            // 
            this.lblstateTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstateTotal.Location = new System.Drawing.Point(163, 290);
            this.lblstateTotal.Name = "lblstateTotal";
            this.lblstateTotal.Size = new System.Drawing.Size(162, 23);
            this.lblstateTotal.TabIndex = 14;
            // 
            // lblnetTotal
            // 
            this.lblnetTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnetTotal.Location = new System.Drawing.Point(163, 337);
            this.lblnetTotal.Name = "lblnetTotal";
            this.lblnetTotal.Size = new System.Drawing.Size(162, 23);
            this.lblnetTotal.TabIndex = 15;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(195, 390);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblnetTotal);
            this.Controls.Add(this.lblstateTotal);
            this.Controls.Add(this.lblfederalTotal);
            this.Controls.Add(this.lblgrossTotal);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblFederal);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtSecurity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblhoursWorked);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblSecurity);
            this.Controls.Add(this.lblName);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblhoursWorked;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSecurity;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblFederal;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblgrossTotal;
        private System.Windows.Forms.Label lblfederalTotal;
        private System.Windows.Forms.Label lblstateTotal;
        private System.Windows.Forms.Label lblnetTotal;
        private System.Windows.Forms.Button btnCalc;
    }
}

