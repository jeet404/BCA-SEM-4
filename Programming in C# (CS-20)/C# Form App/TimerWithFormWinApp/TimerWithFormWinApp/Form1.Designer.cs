namespace TimerWithFormWinApp
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
            this.tmr_main = new System.Windows.Forms.Timer(this.components);
            this.pnl_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tmr_main
            // 
            this.tmr_main.Tick += new System.EventHandler(this.tmr_main_Tick);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Location = new System.Drawing.Point(12, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(560, 450);
            this.pnl_main.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 475);
            this.Controls.Add(this.pnl_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_main;
        private System.Windows.Forms.Panel pnl_main;
    }
}

