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
            this.SuspendLayout();
            // 
            // stockListBox
            // 
            this.stockListBox.FormattingEnabled = true;
            this.stockListBox.Location = new System.Drawing.Point(12, 12);
            this.stockListBox.Name = "stockListBox";
            this.stockListBox.Size = new System.Drawing.Size(168, 225);
            this.stockListBox.TabIndex = 0;
            // 
            // currentPriceListbox
            // 
            this.currentPriceListbox.FormattingEnabled = true;
            this.currentPriceListbox.Location = new System.Drawing.Point(186, 12);
            this.currentPriceListbox.Name = "currentPriceListbox";
            this.currentPriceListbox.Size = new System.Drawing.Size(92, 225);
            this.currentPriceListbox.TabIndex = 1;
            // 
            // relativeDifferenceListBox
            // 
            this.relativeDifferenceListBox.FormattingEnabled = true;
            this.relativeDifferenceListBox.Location = new System.Drawing.Point(284, 12);
            this.relativeDifferenceListBox.Name = "relativeDifferenceListBox";
            this.relativeDifferenceListBox.Size = new System.Drawing.Size(92, 225);
            this.relativeDifferenceListBox.TabIndex = 2;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 252);
            this.Controls.Add(this.relativeDifferenceListBox);
            this.Controls.Add(this.currentPriceListbox);
            this.Controls.Add(this.stockListBox);
            this.Name = "BoardForm";
            this.Text = "Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox stockListBox;
        private System.Windows.Forms.ListBox currentPriceListbox;
        private System.Windows.Forms.ListBox relativeDifferenceListBox;
    }
}