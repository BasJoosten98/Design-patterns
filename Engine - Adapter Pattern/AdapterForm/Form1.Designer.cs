namespace AdapterForm
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
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.btnSpeedUp = new System.Windows.Forms.Button();
            this.btnSlowDown = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.gbTestEngine = new System.Windows.Forms.GroupBox();
            this.gbCreateEngine = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrake = new System.Windows.Forms.TextBox();
            this.tbGas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateEngine = new System.Windows.Forms.Button();
            this.gbTestEngine.SuspendLayout();
            this.gbCreateEngine.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(6, 19);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(75, 23);
            this.btnPowerOn.TabIndex = 0;
            this.btnPowerOn.Text = "Power On";
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // btnSpeedUp
            // 
            this.btnSpeedUp.Location = new System.Drawing.Point(6, 49);
            this.btnSpeedUp.Name = "btnSpeedUp";
            this.btnSpeedUp.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedUp.TabIndex = 1;
            this.btnSpeedUp.Text = "Speed up";
            this.btnSpeedUp.UseVisualStyleBackColor = true;
            this.btnSpeedUp.Click += new System.EventHandler(this.btnSpeedUp_Click);
            // 
            // btnSlowDown
            // 
            this.btnSlowDown.Location = new System.Drawing.Point(6, 79);
            this.btnSlowDown.Name = "btnSlowDown";
            this.btnSlowDown.Size = new System.Drawing.Size(75, 23);
            this.btnSlowDown.TabIndex = 2;
            this.btnSlowDown.Text = "Slow Down";
            this.btnSlowDown.UseVisualStyleBackColor = true;
            this.btnSlowDown.Click += new System.EventHandler(this.btnSlowDown_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(138, 28);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(87, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Current Speed: 0";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(141, 49);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(91, 13);
            this.lblPower.TabIndex = 4;
            this.lblPower.Text = "Engine Power: off";
            // 
            // gbTestEngine
            // 
            this.gbTestEngine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbTestEngine.Controls.Add(this.btnPowerOn);
            this.gbTestEngine.Controls.Add(this.lblPower);
            this.gbTestEngine.Controls.Add(this.btnSpeedUp);
            this.gbTestEngine.Controls.Add(this.lblSpeed);
            this.gbTestEngine.Controls.Add(this.btnSlowDown);
            this.gbTestEngine.Location = new System.Drawing.Point(12, 12);
            this.gbTestEngine.Name = "gbTestEngine";
            this.gbTestEngine.Size = new System.Drawing.Size(285, 112);
            this.gbTestEngine.TabIndex = 5;
            this.gbTestEngine.TabStop = false;
            this.gbTestEngine.Text = "Test Engine";
            // 
            // gbCreateEngine
            // 
            this.gbCreateEngine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbCreateEngine.Controls.Add(this.btnCreateEngine);
            this.gbCreateEngine.Controls.Add(this.tbGas);
            this.gbCreateEngine.Controls.Add(this.label3);
            this.gbCreateEngine.Controls.Add(this.tbBrake);
            this.gbCreateEngine.Controls.Add(this.label2);
            this.gbCreateEngine.Location = new System.Drawing.Point(12, 147);
            this.gbCreateEngine.Name = "gbCreateEngine";
            this.gbCreateEngine.Size = new System.Drawing.Size(285, 95);
            this.gbCreateEngine.TabIndex = 6;
            this.gbCreateEngine.TabStop = false;
            this.gbCreateEngine.Text = "Create Engine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brake Power";
            // 
            // tbBrake
            // 
            this.tbBrake.Location = new System.Drawing.Point(10, 37);
            this.tbBrake.Name = "tbBrake";
            this.tbBrake.Size = new System.Drawing.Size(100, 20);
            this.tbBrake.TabIndex = 1;
            // 
            // tbGas
            // 
            this.tbGas.Location = new System.Drawing.Point(141, 37);
            this.tbGas.Name = "tbGas";
            this.tbGas.Size = new System.Drawing.Size(100, 20);
            this.tbGas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gas Power";
            // 
            // btnCreateEngine
            // 
            this.btnCreateEngine.Location = new System.Drawing.Point(10, 64);
            this.btnCreateEngine.Name = "btnCreateEngine";
            this.btnCreateEngine.Size = new System.Drawing.Size(269, 23);
            this.btnCreateEngine.TabIndex = 4;
            this.btnCreateEngine.Text = "Create Engine";
            this.btnCreateEngine.UseVisualStyleBackColor = true;
            this.btnCreateEngine.Click += new System.EventHandler(this.btnCreateEngine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 254);
            this.Controls.Add(this.gbCreateEngine);
            this.Controls.Add(this.gbTestEngine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTestEngine.ResumeLayout(false);
            this.gbTestEngine.PerformLayout();
            this.gbCreateEngine.ResumeLayout(false);
            this.gbCreateEngine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPowerOn;
        private System.Windows.Forms.Button btnSpeedUp;
        private System.Windows.Forms.Button btnSlowDown;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.GroupBox gbTestEngine;
        private System.Windows.Forms.GroupBox gbCreateEngine;
        private System.Windows.Forms.Button btnCreateEngine;
        private System.Windows.Forms.TextBox tbGas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBrake;
        private System.Windows.Forms.Label label2;
    }
}

