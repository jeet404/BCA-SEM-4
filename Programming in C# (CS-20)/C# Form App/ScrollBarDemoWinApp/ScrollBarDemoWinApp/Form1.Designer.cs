namespace ScrollBarDemoWinApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.txt_schange = new System.Windows.Forms.TextBox();
            this.txt_lchange = new System.Windows.Forms.TextBox();
            this.txt_val = new System.Windows.Forms.TextBox();
            this.hsb_main = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "LargeChange";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SmallChange";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Value";
            // 
            // txt_min
            // 
            this.txt_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_min.Location = new System.Drawing.Point(171, 16);
            this.txt_min.Name = "txt_min";
            this.txt_min.ReadOnly = true;
            this.txt_min.Size = new System.Drawing.Size(149, 26);
            this.txt_min.TabIndex = 5;
            this.txt_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_max
            // 
            this.txt_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_max.Location = new System.Drawing.Point(171, 48);
            this.txt_max.Name = "txt_max";
            this.txt_max.ReadOnly = true;
            this.txt_max.Size = new System.Drawing.Size(149, 26);
            this.txt_max.TabIndex = 6;
            this.txt_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_schange
            // 
            this.txt_schange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_schange.Location = new System.Drawing.Point(171, 112);
            this.txt_schange.Name = "txt_schange";
            this.txt_schange.ReadOnly = true;
            this.txt_schange.Size = new System.Drawing.Size(149, 26);
            this.txt_schange.TabIndex = 7;
            this.txt_schange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_lchange
            // 
            this.txt_lchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lchange.Location = new System.Drawing.Point(171, 80);
            this.txt_lchange.Name = "txt_lchange";
            this.txt_lchange.ReadOnly = true;
            this.txt_lchange.Size = new System.Drawing.Size(149, 26);
            this.txt_lchange.TabIndex = 8;
            this.txt_lchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_val
            // 
            this.txt_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_val.Location = new System.Drawing.Point(171, 144);
            this.txt_val.Name = "txt_val";
            this.txt_val.ReadOnly = true;
            this.txt_val.Size = new System.Drawing.Size(149, 26);
            this.txt_val.TabIndex = 9;
            this.txt_val.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hsb_main
            // 
            this.hsb_main.LargeChange = 50;
            this.hsb_main.Location = new System.Drawing.Point(16, 216);
            this.hsb_main.Maximum = 1000;
            this.hsb_main.Name = "hsb_main";
            this.hsb_main.Size = new System.Drawing.Size(304, 17);
            this.hsb_main.SmallChange = 15;
            this.hsb_main.TabIndex = 10;
            this.hsb_main.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsb_main_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(341, 257);
            this.Controls.Add(this.hsb_main);
            this.Controls.Add(this.txt_val);
            this.Controls.Add(this.txt_lchange);
            this.Controls.Add(this.txt_schange);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.TextBox txt_schange;
        private System.Windows.Forms.TextBox txt_lchange;
        private System.Windows.Forms.TextBox txt_val;
        private System.Windows.Forms.HScrollBar hsb_main;
    }
}

