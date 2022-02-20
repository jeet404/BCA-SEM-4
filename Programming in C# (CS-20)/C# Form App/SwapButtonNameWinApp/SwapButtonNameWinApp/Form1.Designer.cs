namespace SwapButtonNameWinApp
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
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_second = new System.Windows.Forms.Button();
            this.btn_third = new System.Windows.Forms.Button();
            this.btn_fourth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Location = new System.Drawing.Point(86, 54);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 30);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "1st";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btm_first_Click);
            // 
            // btn_second
            // 
            this.btn_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_second.Location = new System.Drawing.Point(158, 90);
            this.btn_second.Name = "btn_second";
            this.btn_second.Size = new System.Drawing.Size(75, 30);
            this.btn_second.TabIndex = 1;
            this.btn_second.Text = "2nd";
            this.btn_second.UseVisualStyleBackColor = true;
            this.btn_second.Click += new System.EventHandler(this.btn_second_Click);
            // 
            // btn_third
            // 
            this.btn_third.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_third.Location = new System.Drawing.Point(86, 126);
            this.btn_third.Name = "btn_third";
            this.btn_third.Size = new System.Drawing.Size(75, 30);
            this.btn_third.TabIndex = 2;
            this.btn_third.Text = "3rd";
            this.btn_third.UseVisualStyleBackColor = true;
            this.btn_third.Click += new System.EventHandler(this.btn_third_Click);
            // 
            // btn_fourth
            // 
            this.btn_fourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fourth.Location = new System.Drawing.Point(12, 90);
            this.btn_fourth.Name = "btn_fourth";
            this.btn_fourth.Size = new System.Drawing.Size(75, 30);
            this.btn_fourth.TabIndex = 3;
            this.btn_fourth.Text = "4th";
            this.btn_fourth.UseVisualStyleBackColor = true;
            this.btn_fourth.Click += new System.EventHandler(this.btn_fourth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 216);
            this.Controls.Add(this.btn_fourth);
            this.Controls.Add(this.btn_third);
            this.Controls.Add(this.btn_second);
            this.Controls.Add(this.btn_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_second;
        private System.Windows.Forms.Button btn_third;
        private System.Windows.Forms.Button btn_fourth;
    }
}

