namespace CommandForm
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
            this.lbLamps = new System.Windows.Forms.ListBox();
            this.lbActions = new System.Windows.Forms.ListBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLamps
            // 
            this.lbLamps.FormattingEnabled = true;
            this.lbLamps.Location = new System.Drawing.Point(12, 12);
            this.lbLamps.Name = "lbLamps";
            this.lbLamps.Size = new System.Drawing.Size(120, 160);
            this.lbLamps.TabIndex = 0;
            // 
            // lbActions
            // 
            this.lbActions.FormattingEnabled = true;
            this.lbActions.Location = new System.Drawing.Point(138, 12);
            this.lbActions.Name = "lbActions";
            this.lbActions.Size = new System.Drawing.Size(120, 160);
            this.lbActions.TabIndex = 1;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(468, 63);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(59, 50);
            this.picBox1.TabIndex = 2;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(600, 63);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(59, 50);
            this.picBox2.TabIndex = 3;
            this.picBox2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Animation";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(274, 42);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 187);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.lbActions);
            this.Controls.Add(this.lbLamps);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLamps;
        private System.Windows.Forms.ListBox lbActions;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer1;
    }
}

