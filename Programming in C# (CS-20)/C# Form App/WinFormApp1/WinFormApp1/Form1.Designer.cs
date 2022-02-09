namespace WinFormApp1
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
            this.btn_copy = new System.Windows.Forms.Button();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_fourth = new System.Windows.Forms.TextBox();
            this.txt_third = new System.Windows.Forms.TextBox();
            this.txt_second = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.Cyan;
            this.btn_copy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(238, 386);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(98, 37);
            this.btn_copy.TabIndex = 1;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // txt_first
            // 
            this.txt_first.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_first.Location = new System.Drawing.Point(89, 122);
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(169, 26);
            this.txt_first.TabIndex = 2;
            this.txt_first.Text = "Hello";
            this.txt_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_first.Leave += new System.EventHandler(this.txt_first_Leave);
            // 
            // txt_fourth
            // 
            this.txt_fourth.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_fourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fourth.Location = new System.Drawing.Point(89, 218);
            this.txt_fourth.Name = "txt_fourth";
            this.txt_fourth.Size = new System.Drawing.Size(169, 26);
            this.txt_fourth.TabIndex = 3;
            this.txt_fourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_third
            // 
            this.txt_third.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_third.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_third.Location = new System.Drawing.Point(89, 186);
            this.txt_third.Name = "txt_third";
            this.txt_third.Size = new System.Drawing.Size(169, 26);
            this.txt_third.TabIndex = 5;
            this.txt_third.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_second
            // 
            this.txt_second.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_second.Location = new System.Drawing.Point(89, 154);
            this.txt_second.Name = "txt_second";
            this.txt_second.Size = new System.Drawing.Size(169, 26);
            this.txt_second.TabIndex = 6;
            this.txt_second.Text = "Bye";
            this.txt_second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_second.Leave += new System.EventHandler(this.txt_second_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "First C# Windows Form Application";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cyan;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(348, 435);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_third);
            this.Controls.Add(this.txt_fourth);
            this.Controls.Add(this.txt_first);
            this.Controls.Add(this.btn_copy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.TextBox txt_fourth;
        private System.Windows.Forms.TextBox txt_third;
        private System.Windows.Forms.TextBox txt_second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}

