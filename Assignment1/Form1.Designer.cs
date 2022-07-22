namespace Assignment1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.snowWithout = new System.Windows.Forms.TextBox();
            this.snowWith = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.snowWithoutPrice = new System.Windows.Forms.TextBox();
            this.snowWithPrice = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dailySnowWithout = new System.Windows.Forms.TextBox();
            this.dailySnowWith = new System.Windows.Forms.TextBox();
            this.dailyTotal = new System.Windows.Forms.TextBox();
            this.customerAve = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Customer Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Driver\'s License / ID Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Snowboards Without Boots:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Snowboards With Boots:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(438, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 5;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(438, 77);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 23);
            this.id.TabIndex = 6;
            // 
            // snowWithout
            // 
            this.snowWithout.Location = new System.Drawing.Point(438, 111);
            this.snowWithout.Name = "snowWithout";
            this.snowWithout.Size = new System.Drawing.Size(100, 23);
            this.snowWithout.TabIndex = 7;
            // 
            // snowWith
            // 
            this.snowWith.Location = new System.Drawing.Point(438, 140);
            this.snowWith.Name = "snowWith";
            this.snowWith.Size = new System.Drawing.Size(100, 23);
            this.snowWith.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current Rental Summary ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Daily Rental Summary ";
            // 
            // snowWithoutPrice
            // 
            this.snowWithoutPrice.Location = new System.Drawing.Point(225, 278);
            this.snowWithoutPrice.Name = "snowWithoutPrice";
            this.snowWithoutPrice.Size = new System.Drawing.Size(100, 23);
            this.snowWithoutPrice.TabIndex = 11;
            // 
            // snowWithPrice
            // 
            this.snowWithPrice.Location = new System.Drawing.Point(225, 307);
            this.snowWithPrice.Name = "snowWithPrice";
            this.snowWithPrice.Size = new System.Drawing.Size(100, 23);
            this.snowWithPrice.TabIndex = 12;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(225, 336);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 23);
            this.total.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Snowboards Without Boots ($):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Snowboards With Boots ($):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Rental Total ($):";
            // 
            // dailySnowWithout
            // 
            this.dailySnowWithout.Location = new System.Drawing.Point(625, 278);
            this.dailySnowWithout.Name = "dailySnowWithout";
            this.dailySnowWithout.Size = new System.Drawing.Size(100, 23);
            this.dailySnowWithout.TabIndex = 17;
            // 
            // dailySnowWith
            // 
            this.dailySnowWith.Location = new System.Drawing.Point(625, 307);
            this.dailySnowWith.Name = "dailySnowWith";
            this.dailySnowWith.Size = new System.Drawing.Size(100, 23);
            this.dailySnowWith.TabIndex = 18;
            // 
            // dailyTotal
            // 
            this.dailyTotal.Location = new System.Drawing.Point(625, 336);
            this.dailyTotal.Name = "dailyTotal";
            this.dailyTotal.Size = new System.Drawing.Size(100, 23);
            this.dailyTotal.TabIndex = 19;
            // 
            // customerAve
            // 
            this.customerAve.Location = new System.Drawing.Point(625, 365);
            this.customerAve.Name = "customerAve";
            this.customerAve.Size = new System.Drawing.Size(100, 23);
            this.customerAve.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Snowboards Without Boots ($):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Snowboards With Boots ($): ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(499, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Daily Rental Total ($): ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Daily Customer Total Average ($): ";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(110, 450);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(109, 23);
            this.btnCalc.TabIndex = 25;
            this.btnCalc.Text = "Calculate Order";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(241, 450);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 26;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Location = new System.Drawing.Point(335, 450);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(75, 23);
            this.clearAllBtn.TabIndex = 27;
            this.clearAllBtn.Text = "Clear All";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(587, 450);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 28;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.customerAve);
            this.Controls.Add(this.dailyTotal);
            this.Controls.Add(this.dailySnowWith);
            this.Controls.Add(this.dailySnowWithout);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total);
            this.Controls.Add(this.snowWithPrice);
            this.Controls.Add(this.snowWithoutPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.snowWith);
            this.Controls.Add(this.snowWithout);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Snowboard Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name;
        private TextBox id;
        private TextBox snowWithout;
        private TextBox snowWith;
        private Label label6;
        private Label label7;
        private TextBox snowWithoutPrice;
        private TextBox snowWithPrice;
        private TextBox total;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox dailySnowWithout;
        private TextBox dailySnowWith;
        private TextBox dailyTotal;
        private TextBox customerAve;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnCalc;
        private Button clearBtn;
        private Button clearAllBtn;
        private Button exitBtn;
    }
}