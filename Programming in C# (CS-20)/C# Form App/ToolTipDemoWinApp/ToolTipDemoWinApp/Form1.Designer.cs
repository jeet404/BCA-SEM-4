namespace ToolTipDemoWinApp
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
            this.btn_tip = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_tip
            // 
            this.btn_tip.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tip.Location = new System.Drawing.Point(100, 34);
            this.btn_tip.Name = "btn_tip";
            this.btn_tip.Size = new System.Drawing.Size(119, 36);
            this.btn_tip.TabIndex = 0;
            this.btn_tip.Text = "Show Tip";
            this.toolTip1.SetToolTip(this.btn_tip, "Click Me ");
            this.btn_tip.UseVisualStyleBackColor = true;
            this.btn_tip.Click += new System.EventHandler(this.btn_tip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 104);
            this.Controls.Add(this.btn_tip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tip;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

