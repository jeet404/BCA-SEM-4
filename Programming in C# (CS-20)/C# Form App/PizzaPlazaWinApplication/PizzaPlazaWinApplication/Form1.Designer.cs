namespace PizzaPlazaWinApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.item_4 = new System.Windows.Forms.CheckBox();
            this.item_3 = new System.Windows.Forms.CheckBox();
            this.item_2 = new System.Windows.Forms.CheckBox();
            this.item_1 = new System.Windows.Forms.CheckBox();
            this.qty_1 = new System.Windows.Forms.NumericUpDown();
            this.qty_2 = new System.Windows.Forms.NumericUpDown();
            this.qty_3 = new System.Windows.Forms.NumericUpDown();
            this.qty_4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_p3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_p4 = new System.Windows.Forms.Label();
            this.lbl_p2 = new System.Windows.Forms.Label();
            this.lbl_p1 = new System.Windows.Forms.Label();
            this.chk_parcel = new System.Windows.Forms.CheckBox();
            this.lbl_itemtotal = new System.Windows.Forms.Label();
            this.lbl_parcel = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_small = new System.Windows.Forms.CheckBox();
            this.chk_mid = new System.Windows.Forms.CheckBox();
            this.chk_large = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.qty_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Plaza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Size : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose Items";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_4
            // 
            this.item_4.AutoSize = true;
            this.item_4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_4.Location = new System.Drawing.Point(12, 256);
            this.item_4.Name = "item_4";
            this.item_4.Size = new System.Drawing.Size(108, 21);
            this.item_4.TabIndex = 6;
            this.item_4.Text = "Hot-Spicy";
            this.item_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.item_4.UseVisualStyleBackColor = true;
            this.item_4.CheckedChanged += new System.EventHandler(this.item_4_CheckedChanged);
            // 
            // item_3
            // 
            this.item_3.AutoSize = true;
            this.item_3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_3.Location = new System.Drawing.Point(12, 225);
            this.item_3.Name = "item_3";
            this.item_3.Size = new System.Drawing.Size(162, 21);
            this.item_3.TabIndex = 7;
            this.item_3.Text = "Tandoori Paneer";
            this.item_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.item_3.UseVisualStyleBackColor = true;
            this.item_3.CheckedChanged += new System.EventHandler(this.item_3_CheckedChanged);
            // 
            // item_2
            // 
            this.item_2.AutoSize = true;
            this.item_2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_2.Location = new System.Drawing.Point(12, 194);
            this.item_2.Name = "item_2";
            this.item_2.Size = new System.Drawing.Size(108, 21);
            this.item_2.TabIndex = 8;
            this.item_2.Text = "Margarita";
            this.item_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.item_2.UseVisualStyleBackColor = true;
            this.item_2.CheckedChanged += new System.EventHandler(this.item_2_CheckedChanged);
            // 
            // item_1
            // 
            this.item_1.AutoSize = true;
            this.item_1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_1.Location = new System.Drawing.Point(12, 163);
            this.item_1.Name = "item_1";
            this.item_1.Size = new System.Drawing.Size(135, 21);
            this.item_1.TabIndex = 9;
            this.item_1.Text = "Seven Cheeze";
            this.item_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.item_1.UseVisualStyleBackColor = true;
            this.item_1.CheckedChanged += new System.EventHandler(this.item_1_CheckedChanged);
            // 
            // qty_1
            // 
            this.qty_1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_1.Location = new System.Drawing.Point(179, 162);
            this.qty_1.Name = "qty_1";
            this.qty_1.Size = new System.Drawing.Size(120, 25);
            this.qty_1.TabIndex = 10;
            this.qty_1.ValueChanged += new System.EventHandler(this.qty_1_ValueChanged);
            // 
            // qty_2
            // 
            this.qty_2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_2.Location = new System.Drawing.Point(179, 193);
            this.qty_2.Name = "qty_2";
            this.qty_2.Size = new System.Drawing.Size(120, 25);
            this.qty_2.TabIndex = 11;
            this.qty_2.ValueChanged += new System.EventHandler(this.qty_2_ValueChanged);
            // 
            // qty_3
            // 
            this.qty_3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_3.Location = new System.Drawing.Point(179, 224);
            this.qty_3.Name = "qty_3";
            this.qty_3.Size = new System.Drawing.Size(120, 25);
            this.qty_3.TabIndex = 12;
            this.qty_3.ValueChanged += new System.EventHandler(this.qty_3_ValueChanged);
            // 
            // qty_4
            // 
            this.qty_4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_4.Location = new System.Drawing.Point(179, 255);
            this.qty_4.Name = "qty_4";
            this.qty_4.Size = new System.Drawing.Size(120, 25);
            this.qty_4.TabIndex = 13;
            this.qty_4.ValueChanged += new System.EventHandler(this.qty_4_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "QTY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p3
            // 
            this.lbl_p3.AutoSize = true;
            this.lbl_p3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p3.Location = new System.Drawing.Point(376, 228);
            this.lbl_p3.Name = "lbl_p3";
            this.lbl_p3.Size = new System.Drawing.Size(0, 18);
            this.lbl_p3.TabIndex = 16;
            this.lbl_p3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "---|_ Estimate _|---";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p4
            // 
            this.lbl_p4.AutoSize = true;
            this.lbl_p4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p4.Location = new System.Drawing.Point(376, 259);
            this.lbl_p4.Name = "lbl_p4";
            this.lbl_p4.Size = new System.Drawing.Size(0, 18);
            this.lbl_p4.TabIndex = 18;
            this.lbl_p4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2
            // 
            this.lbl_p2.AutoSize = true;
            this.lbl_p2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2.Location = new System.Drawing.Point(376, 197);
            this.lbl_p2.Name = "lbl_p2";
            this.lbl_p2.Size = new System.Drawing.Size(0, 18);
            this.lbl_p2.TabIndex = 19;
            this.lbl_p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1
            // 
            this.lbl_p1.AutoSize = true;
            this.lbl_p1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1.Location = new System.Drawing.Point(376, 166);
            this.lbl_p1.Name = "lbl_p1";
            this.lbl_p1.Size = new System.Drawing.Size(0, 18);
            this.lbl_p1.TabIndex = 20;
            this.lbl_p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_parcel
            // 
            this.chk_parcel.AutoSize = true;
            this.chk_parcel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_parcel.Location = new System.Drawing.Point(15, 329);
            this.chk_parcel.Name = "chk_parcel";
            this.chk_parcel.Size = new System.Drawing.Size(137, 22);
            this.chk_parcel.TabIndex = 21;
            this.chk_parcel.Text = "With Parcel";
            this.chk_parcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_parcel.UseVisualStyleBackColor = true;
            this.chk_parcel.CheckedChanged += new System.EventHandler(this.chk_parcel_CheckedChanged);
            // 
            // lbl_itemtotal
            // 
            this.lbl_itemtotal.AutoSize = true;
            this.lbl_itemtotal.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemtotal.Location = new System.Drawing.Point(665, 163);
            this.lbl_itemtotal.Name = "lbl_itemtotal";
            this.lbl_itemtotal.Size = new System.Drawing.Size(18, 18);
            this.lbl_itemtotal.TabIndex = 22;
            this.lbl_itemtotal.Text = "0";
            this.lbl_itemtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_parcel
            // 
            this.lbl_parcel.AutoSize = true;
            this.lbl_parcel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parcel.Location = new System.Drawing.Point(665, 193);
            this.lbl_parcel.Name = "lbl_parcel";
            this.lbl_parcel.Size = new System.Drawing.Size(18, 18);
            this.lbl_parcel.TabIndex = 23;
            this.lbl_parcel.Text = "0";
            this.lbl_parcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(665, 235);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(18, 18);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(714, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "- Total";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(620, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "___________________";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(714, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "- Parcel";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(586, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "Calculate Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_small
            // 
            this.chk_small.AutoSize = true;
            this.chk_small.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_small.Location = new System.Drawing.Point(146, 89);
            this.chk_small.Name = "chk_small";
            this.chk_small.Size = new System.Drawing.Size(77, 22);
            this.chk_small.TabIndex = 2;
            this.chk_small.Text = "Small";
            this.chk_small.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_small.UseVisualStyleBackColor = true;
            this.chk_small.CheckedChanged += new System.EventHandler(this.chk_small_CheckedChanged);
            // 
            // chk_mid
            // 
            this.chk_mid.AutoSize = true;
            this.chk_mid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mid.Location = new System.Drawing.Point(264, 89);
            this.chk_mid.Name = "chk_mid";
            this.chk_mid.Size = new System.Drawing.Size(87, 22);
            this.chk_mid.TabIndex = 3;
            this.chk_mid.Text = "Medium";
            this.chk_mid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_mid.UseVisualStyleBackColor = true;
            this.chk_mid.CheckedChanged += new System.EventHandler(this.chk_mid_CheckedChanged);
            // 
            // chk_large
            // 
            this.chk_large.AutoSize = true;
            this.chk_large.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_large.Location = new System.Drawing.Point(387, 89);
            this.chk_large.Name = "chk_large";
            this.chk_large.Size = new System.Drawing.Size(77, 22);
            this.chk_large.TabIndex = 4;
            this.chk_large.Text = "Large";
            this.chk_large.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_large.UseVisualStyleBackColor = true;
            this.chk_large.CheckedChanged += new System.EventHandler(this.chk_large_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_parcel);
            this.Controls.Add(this.lbl_itemtotal);
            this.Controls.Add(this.chk_parcel);
            this.Controls.Add(this.lbl_p1);
            this.Controls.Add(this.lbl_p2);
            this.Controls.Add(this.lbl_p4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_p3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qty_4);
            this.Controls.Add(this.qty_3);
            this.Controls.Add(this.qty_2);
            this.Controls.Add(this.qty_1);
            this.Controls.Add(this.item_1);
            this.Controls.Add(this.item_2);
            this.Controls.Add(this.item_3);
            this.Controls.Add(this.item_4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_large);
            this.Controls.Add(this.chk_mid);
            this.Controls.Add(this.chk_small);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qty_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox item_4;
        private System.Windows.Forms.CheckBox item_3;
        private System.Windows.Forms.CheckBox item_2;
        private System.Windows.Forms.CheckBox item_1;
        private System.Windows.Forms.NumericUpDown qty_1;
        private System.Windows.Forms.NumericUpDown qty_2;
        private System.Windows.Forms.NumericUpDown qty_3;
        private System.Windows.Forms.NumericUpDown qty_4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_p3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_p4;
        private System.Windows.Forms.Label lbl_p2;
        private System.Windows.Forms.Label lbl_p1;
        private System.Windows.Forms.CheckBox chk_parcel;
        private System.Windows.Forms.Label lbl_itemtotal;
        private System.Windows.Forms.Label lbl_parcel;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_small;
        private System.Windows.Forms.CheckBox chk_mid;
        private System.Windows.Forms.CheckBox chk_large;
    }
}

