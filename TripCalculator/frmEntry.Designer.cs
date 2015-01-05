namespace TripCalculator
{
    partial class frmEntry
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
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblNumTrolley = new System.Windows.Forms.Label();
            this.txtNumTrolley = new System.Windows.Forms.TextBox();
            this.lblSelection = new System.Windows.Forms.Label();
            this.cboSelection = new System.Windows.Forms.ComboBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblVehicleSelection = new System.Windows.Forms.Label();
            this.cboVehicleSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(15, 140);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 17);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "*";
            this.lblTime.Visible = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(18, 315);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 29);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(15, 168);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(13, 17);
            this.lblDisplay.TabIndex = 19;
            this.lblDisplay.Text = "*";
            // 
            // lblNumTrolley
            // 
            this.lblNumTrolley.AutoSize = true;
            this.lblNumTrolley.Location = new System.Drawing.Point(15, 102);
            this.lblNumTrolley.Name = "lblNumTrolley";
            this.lblNumTrolley.Size = new System.Drawing.Size(216, 17);
            this.lblNumTrolley.TabIndex = 18;
            this.lblNumTrolley.Text = "Enter the Number of Trolley Cars";
            this.lblNumTrolley.Visible = false;
            // 
            // txtNumTrolley
            // 
            this.txtNumTrolley.Location = new System.Drawing.Point(251, 99);
            this.txtNumTrolley.Name = "txtNumTrolley";
            this.txtNumTrolley.Size = new System.Drawing.Size(45, 22);
            this.txtNumTrolley.TabIndex = 17;
            this.txtNumTrolley.Tag = "Number of Trolley Cars";
            this.txtNumTrolley.Visible = false;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(15, 72);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(13, 17);
            this.lblSelection.TabIndex = 16;
            this.lblSelection.Text = "*";
            this.lblSelection.Visible = false;
            // 
            // cboSelection
            // 
            this.cboSelection.FormattingEnabled = true;
            this.cboSelection.Location = new System.Drawing.Point(175, 69);
            this.cboSelection.Name = "cboSelection";
            this.cboSelection.Size = new System.Drawing.Size(121, 24);
            this.cboSelection.TabIndex = 15;
            this.cboSelection.Tag = "Selection";
            this.cboSelection.Visible = false;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(196, 11);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 22);
            this.txtDistance.TabIndex = 10;
            this.txtDistance.Tag = "Distance in Miles";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(15, 14);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(152, 17);
            this.lblDistance.TabIndex = 13;
            this.lblDistance.Text = "Enter Distance in Miles";
            // 
            // lblVehicleSelection
            // 
            this.lblVehicleSelection.AutoSize = true;
            this.lblVehicleSelection.Location = new System.Drawing.Point(15, 42);
            this.lblVehicleSelection.Name = "lblVehicleSelection";
            this.lblVehicleSelection.Size = new System.Drawing.Size(97, 17);
            this.lblVehicleSelection.TabIndex = 11;
            this.lblVehicleSelection.Text = "Select Vehicle";
            // 
            // cboVehicleSelection
            // 
            this.cboVehicleSelection.FormattingEnabled = true;
            this.cboVehicleSelection.Items.AddRange(new object[] {
            "Automobile",
            "Plane",
            "Train"});
            this.cboVehicleSelection.Location = new System.Drawing.Point(175, 39);
            this.cboVehicleSelection.Name = "cboVehicleSelection";
            this.cboVehicleSelection.Size = new System.Drawing.Size(121, 24);
            this.cboVehicleSelection.TabIndex = 12;
            this.cboVehicleSelection.Tag = "Select Vehicle";
            this.cboVehicleSelection.SelectedIndexChanged += new System.EventHandler(this.cboVehicleSelection_SelectedIndexChanged);
            // 
            // frmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 355);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblNumTrolley);
            this.Controls.Add(this.txtNumTrolley);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.cboSelection);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblVehicleSelection);
            this.Controls.Add(this.cboVehicleSelection);
            this.Name = "frmEntry";
            this.Text = "Trip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblNumTrolley;
        private System.Windows.Forms.TextBox txtNumTrolley;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ComboBox cboSelection;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblVehicleSelection;
        private System.Windows.Forms.ComboBox cboVehicleSelection;
    }
}

