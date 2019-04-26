namespace StockMarket___Observer_Pattern
{
    partial class mainForm
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
            this.openMatrixBoardBtn = new System.Windows.Forms.Button();
            this.openNewsPaperBtn = new System.Windows.Forms.Button();
            this.stockMarketTimer = new System.Windows.Forms.Timer(this.components);
            this.startStopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openMatrixBoardBtn
            // 
            this.openMatrixBoardBtn.Location = new System.Drawing.Point(12, 12);
            this.openMatrixBoardBtn.Name = "openMatrixBoardBtn";
            this.openMatrixBoardBtn.Size = new System.Drawing.Size(136, 36);
            this.openMatrixBoardBtn.TabIndex = 0;
            this.openMatrixBoardBtn.Text = "Open Matrix Board";
            this.openMatrixBoardBtn.UseVisualStyleBackColor = true;
            this.openMatrixBoardBtn.Click += new System.EventHandler(this.openMatrixBoardBtn_Click);
            // 
            // openNewsPaperBtn
            // 
            this.openNewsPaperBtn.Location = new System.Drawing.Point(163, 12);
            this.openNewsPaperBtn.Name = "openNewsPaperBtn";
            this.openNewsPaperBtn.Size = new System.Drawing.Size(130, 36);
            this.openNewsPaperBtn.TabIndex = 1;
            this.openNewsPaperBtn.Text = "Open News Paper";
            this.openNewsPaperBtn.UseVisualStyleBackColor = true;
            this.openNewsPaperBtn.Click += new System.EventHandler(this.openNewsPaperBtn_Click);
            // 
            // stockMarketTimer
            // 
            this.stockMarketTimer.Interval = 1000;
            this.stockMarketTimer.Tick += new System.EventHandler(this.stockMarketTimer_Tick_1);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(114, 92);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(75, 23);
            this.startStopBtn.TabIndex = 2;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 127);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.openNewsPaperBtn);
            this.Controls.Add(this.openMatrixBoardBtn);
            this.Name = "mainForm";
            this.Text = "Stock Market Simulation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openMatrixBoardBtn;
        private System.Windows.Forms.Button openNewsPaperBtn;
        private System.Windows.Forms.Timer stockMarketTimer;
        private System.Windows.Forms.Button startStopBtn;
    }
}

