namespace DiskScheduling
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeItemsTimer = new System.Windows.Forms.Timer(this.components);
            this.runBtn = new System.Windows.Forms.Button();
            this.rbScan = new System.Windows.Forms.RadioButton();
            this.rbShortestSeekTimeFirst = new System.Windows.Forms.RadioButton();
            this.rbFirstComeFirstServe = new System.Windows.Forms.RadioButton();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 316);
            this.listBox1.TabIndex = 0;
            // 
            // removeItemsTimer
            // 
            this.removeItemsTimer.Tick += new System.EventHandler(this.removeItemsTimer_Tick);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(353, 36);
            this.runBtn.Margin = new System.Windows.Forms.Padding(2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(85, 29);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // rbScan
            // 
            this.rbScan.AutoSize = true;
            this.rbScan.Location = new System.Drawing.Point(584, 47);
            this.rbScan.Name = "rbScan";
            this.rbScan.Size = new System.Drawing.Size(50, 17);
            this.rbScan.TabIndex = 2;
            this.rbScan.TabStop = true;
            this.rbScan.Text = "Scan";
            this.rbScan.UseVisualStyleBackColor = true;
            this.rbScan.CheckedChanged += new System.EventHandler(this.rbScan_CheckedChanged);
            // 
            // rbShortestSeekTimeFirst
            // 
            this.rbShortestSeekTimeFirst.AutoSize = true;
            this.rbShortestSeekTimeFirst.Location = new System.Drawing.Point(584, 70);
            this.rbShortestSeekTimeFirst.Name = "rbShortestSeekTimeFirst";
            this.rbShortestSeekTimeFirst.Size = new System.Drawing.Size(140, 17);
            this.rbShortestSeekTimeFirst.TabIndex = 3;
            this.rbShortestSeekTimeFirst.TabStop = true;
            this.rbShortestSeekTimeFirst.Text = "Shortest Seek Time First";
            this.rbShortestSeekTimeFirst.UseVisualStyleBackColor = true;
            this.rbShortestSeekTimeFirst.CheckedChanged += new System.EventHandler(this.rbShortestSeekTimeFirst_CheckedChanged);
            // 
            // rbFirstComeFirstServe
            // 
            this.rbFirstComeFirstServe.AutoSize = true;
            this.rbFirstComeFirstServe.Location = new System.Drawing.Point(584, 93);
            this.rbFirstComeFirstServe.Name = "rbFirstComeFirstServe";
            this.rbFirstComeFirstServe.Size = new System.Drawing.Size(127, 17);
            this.rbFirstComeFirstServe.TabIndex = 4;
            this.rbFirstComeFirstServe.TabStop = true;
            this.rbFirstComeFirstServe.Text = "First Come First Serve";
            this.rbFirstComeFirstServe.UseVisualStyleBackColor = true;
            this.rbFirstComeFirstServe.CheckedChanged += new System.EventHandler(this.rbFirstComeFirstServe_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(353, 81);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 29);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(292, 11);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(45, 13);
            this.lblHead.TabIndex = 6;
            this.lblHead.Text = "Head: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 389);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.rbFirstComeFirstServe);
            this.Controls.Add(this.rbShortestSeekTimeFirst);
            this.Controls.Add(this.rbScan);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer removeItemsTimer;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.RadioButton rbScan;
        private System.Windows.Forms.RadioButton rbShortestSeekTimeFirst;
        private System.Windows.Forms.RadioButton rbFirstComeFirstServe;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblHead;
    }
}

