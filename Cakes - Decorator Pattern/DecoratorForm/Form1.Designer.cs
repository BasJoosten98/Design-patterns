namespace DecoratorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCakePlatform = new System.Windows.Forms.ListBox();
            this.lbCakeToppings = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPlatform = new System.Windows.Forms.Button();
            this.btnAddTopping = new System.Windows.Forms.Button();
            this.btnRemoveCake = new System.Windows.Forms.Button();
            this.btnCreateCake = new System.Windows.Forms.Button();
            this.lbYourCake = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cake Platform";
            // 
            // lbCakePlatform
            // 
            this.lbCakePlatform.FormattingEnabled = true;
            this.lbCakePlatform.Location = new System.Drawing.Point(12, 29);
            this.lbCakePlatform.Name = "lbCakePlatform";
            this.lbCakePlatform.Size = new System.Drawing.Size(120, 173);
            this.lbCakePlatform.TabIndex = 1;
            // 
            // lbCakeToppings
            // 
            this.lbCakeToppings.FormattingEnabled = true;
            this.lbCakeToppings.Location = new System.Drawing.Point(153, 29);
            this.lbCakeToppings.Name = "lbCakeToppings";
            this.lbCakeToppings.Size = new System.Drawing.Size(120, 173);
            this.lbCakeToppings.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cake Topping";
            // 
            // btnAddPlatform
            // 
            this.btnAddPlatform.Location = new System.Drawing.Point(12, 202);
            this.btnAddPlatform.Name = "btnAddPlatform";
            this.btnAddPlatform.Size = new System.Drawing.Size(120, 23);
            this.btnAddPlatform.TabIndex = 4;
            this.btnAddPlatform.Text = "Add";
            this.btnAddPlatform.UseVisualStyleBackColor = true;
            this.btnAddPlatform.Click += new System.EventHandler(this.btnAddPlatform_Click);
            // 
            // btnAddTopping
            // 
            this.btnAddTopping.Location = new System.Drawing.Point(153, 202);
            this.btnAddTopping.Name = "btnAddTopping";
            this.btnAddTopping.Size = new System.Drawing.Size(120, 23);
            this.btnAddTopping.TabIndex = 5;
            this.btnAddTopping.Text = "Add";
            this.btnAddTopping.UseVisualStyleBackColor = true;
            this.btnAddTopping.Click += new System.EventHandler(this.btnAddTopping_Click);
            // 
            // btnRemoveCake
            // 
            this.btnRemoveCake.Location = new System.Drawing.Point(323, 13);
            this.btnRemoveCake.Name = "btnRemoveCake";
            this.btnRemoveCake.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveCake.TabIndex = 6;
            this.btnRemoveCake.Text = "Remove Cake";
            this.btnRemoveCake.UseVisualStyleBackColor = true;
            this.btnRemoveCake.Click += new System.EventHandler(this.btnRemoveCake_Click);
            // 
            // btnCreateCake
            // 
            this.btnCreateCake.Location = new System.Drawing.Point(323, 42);
            this.btnCreateCake.Name = "btnCreateCake";
            this.btnCreateCake.Size = new System.Drawing.Size(100, 23);
            this.btnCreateCake.TabIndex = 7;
            this.btnCreateCake.Text = "Create Cake";
            this.btnCreateCake.UseVisualStyleBackColor = true;
            this.btnCreateCake.Click += new System.EventHandler(this.btnCreateCake_Click);
            // 
            // lbYourCake
            // 
            this.lbYourCake.FormattingEnabled = true;
            this.lbYourCake.Location = new System.Drawing.Point(462, 29);
            this.lbYourCake.Name = "lbYourCake";
            this.lbYourCake.Size = new System.Drawing.Size(120, 173);
            this.lbYourCake.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Your Cake";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 237);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbYourCake);
            this.Controls.Add(this.btnCreateCake);
            this.Controls.Add(this.btnRemoveCake);
            this.Controls.Add(this.btnAddTopping);
            this.Controls.Add(this.btnAddPlatform);
            this.Controls.Add(this.lbCakeToppings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCakePlatform);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCakePlatform;
        private System.Windows.Forms.ListBox lbCakeToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPlatform;
        private System.Windows.Forms.Button btnAddTopping;
        private System.Windows.Forms.Button btnRemoveCake;
        private System.Windows.Forms.Button btnCreateCake;
        private System.Windows.Forms.ListBox lbYourCake;
        private System.Windows.Forms.Label label3;
    }
}

