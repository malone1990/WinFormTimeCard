
namespace WinFormTimeCard.UserControls
{
    partial class fmWeekPicker
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
            this.mthcWeekPicker = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // mthcWeekPicker
            // 
            this.mthcWeekPicker.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mthcWeekPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mthcWeekPicker.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mthcWeekPicker.Location = new System.Drawing.Point(0, 0);
            this.mthcWeekPicker.Name = "mthcWeekPicker";
            this.mthcWeekPicker.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2021, 7, 27, 0, 0, 0, 0), new System.DateTime(2021, 7, 30, 0, 0, 0, 0));
            this.mthcWeekPicker.ShowToday = false;
            this.mthcWeekPicker.TabIndex = 2;
            this.mthcWeekPicker.TitleBackColor = System.Drawing.Color.Orange;
            this.mthcWeekPicker.TitleForeColor = System.Drawing.Color.DarkRed;
            this.mthcWeekPicker.TrailingForeColor = System.Drawing.Color.Aquamarine;
            this.mthcWeekPicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mthcWeekPicker_DateChanged);
            this.mthcWeekPicker.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.mthcWeekPicker.MouseLeave += new System.EventHandler(this.monthCalendar1_MouseLeave);
            // 
            // fmWeekPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 334);
            this.Controls.Add(this.mthcWeekPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmWeekPicker";
            this.Text = "fmWeekPicker";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mthcWeekPicker;
    }
}