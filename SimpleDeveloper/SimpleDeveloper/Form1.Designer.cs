namespace SimpleDeveloper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PortGet);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "AirPort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AirPortGet);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Country";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CountryGet);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "State";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.StateGet);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(539, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "City";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CityGet);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(672, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "Location";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.LocationGet);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(805, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 43);
            this.button7.TabIndex = 7;
            this.button7.Text = "Amazon Fulfillment Center";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AmazonFulfillmentCenterGet);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(938, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 43);
            this.button8.TabIndex = 8;
            this.button8.Text = "Forceget Warehouse";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ForcegetWarehouseGet);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1795, 319);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "DataGrid";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(27, 80);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 23);
            this.emailTextBox.TabIndex = 11;
            this.emailTextBox.Text = "sales@forceget.com";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(183, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(139, 23);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.Text = "123456";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(230, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 28);
            this.button9.TabIndex = 13;
            this.button9.Text = "Login";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Login);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 820);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button9;
    }
}
