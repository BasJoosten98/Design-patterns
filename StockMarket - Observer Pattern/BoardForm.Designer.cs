namespace StockMarket___Observer_Pattern
{
    partial class BoardForm
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
            this.stockListBox = new System.Windows.Forms.ListBox();
            this.currentPriceListbox = new System.Windows.Forms.ListBox();
            this.relativeDifferenceListBox = new System.Windows.Forms.ListBox();
            this.stockLb = new System.Windows.Forms.Label();
            this.currentPriceLb = new System.Windows.Forms.Label();
            this.differenceLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stockListBox
            // 
            this.stockListBox.FormattingEnabled = true;
            this.stockListBox.Location = new System.Drawing.Point(12, 40);
            this.stockListBox.Name = "stockListBox";
            this.stockListBox.Size = new System.Drawing.Size(168, 225);
            this.stockListBox.TabIndex = 0;
            // 
            // currentPriceListbox
            // 
            this.currentPriceListbox.FormattingEnabled = true;
            this.currentPriceListbox.Location = new System.Drawing.Point(186, 40);
            this.currentPriceListbox.Name = "currentPriceListbox";
            this.currentPriceListbox.Size = new System.Drawing.Size(92, 225);
            this.currentPriceListbox.TabIndex = 1;
            // 
            // relativeDifferenceListBox
            // 
            this.relativeDifferenceListBox.FormattingEnabled = true;
            this.relativeDifferenceListBox.Location = new System.Drawing.Point(284, 40);
            this.relativeDifferenceListBox.Name = "relativeDifferenceListBox";
            this.relativeDifferenceListBox.Size = new System.Drawing.Size(92, 225);
            this.relativeDifferenceListBox.TabIndex = 2;
            // 
            // stockLb
            // 
            this.stockLb.AutoSize = true;
            this.stockLb.Location = new System.Drawing.Point(69, 24);
            this.stockLb.Name = "stockLb";
            this.stockLb.Size = new System.Drawing.Size(40, 13);
            this.stockLb.TabIndex = 3;
            this.stockLb.Text = "Stocks";
            // 
            // currentPriceLb
            // 
            this.currentPriceLb.AutoSize = true;
            this.currentPriceLb.Location = new System.Drawing.Point(199, 24);
            this.currentPriceLb.Name = "currentPriceLb";
            this.currentPriceLb.Size = new System.Drawing.Size(68, 13);
            this.currentPriceLb.TabIndex = 4;
            this.currentPriceLb.Text = "Current Price";
            // 
            // differenceLb
            // 
            this.differenceLb.AutoSize = true;
            this.differenceLb.Location = new System.Drawing.Point(314, 24);
            this.differenceLb.Name = "differenceLb";
            this.differenceLb.Size = new System.Drawing.Size(32, 13);
            this.differenceLb.TabIndex = 5;
            this.differenceLb.Text = "+/- %";
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 287);
            this.Controls.Add(this.differenceLb);
            this.Controls.Add(this.currentPriceLb);
            this.Controls.Add(this.stockLb);
            this.Controls.Add(this.relativeDifferenceListBox);
            this.Controls.Add(this.currentPriceListbox);
            this.Controls.Add(this.stockListBox);
            this.Name = "BoardForm";
            this.Text = "Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stockListBox;
        private System.Windows.Forms.ListBox currentPriceListbox;
        private System.Windows.Forms.ListBox relativeDifferenceListBox;
        private System.Windows.Forms.Label stockLb;
        private System.Windows.Forms.Label currentPriceLb;
        private System.Windows.Forms.Label differenceLb;
    }
}