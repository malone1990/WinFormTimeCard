
namespace WinFormTimeCard.UserControls
{
    partial class uLblTextbox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(3, 104);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(98, 39);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(3, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDay.Location = new System.Drawing.Point(3, 57);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(78, 32);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "label2";
            // 
            // uLblTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNumber);
            this.Name = "uLblTextbox";
            this.Size = new System.Drawing.Size(106, 148);
            this.Load += new System.EventHandler(this.uLblTextbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDay;
    }
}
