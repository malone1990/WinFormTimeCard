using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormTimeCard.UserControls
{
    public partial class uLblTextbox : UserControl
    {
        public delegate void DelegateUpdateNumber();
        public event DelegateUpdateNumber UpdateNumber;
        private double localNumber = 0;

        public uLblTextbox()
        {
            InitializeComponent();
        }

        public void InitUCInfo(string title, string day, double numbers , bool isToday) 
        {
            this.lblTitle.Text = title;
            this.lblDay.Text = day;
            localNumber = numbers;
            //this.txtNumber.Text = numbers.ToString();
            this.txtNumber.Text = localNumber == 0 ? "" : localNumber.ToString();
            if (isToday)
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = Color.LightGreen;
            }

        }

        public double GetNumber() 
        {
            return localNumber;
        }

        
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            double number = 0;
            if (string.IsNullOrEmpty(txtNumber.Text.Trim()) &&  0 != localNumber)
            {
                localNumber = 0;
                UpdateNumber?.Invoke();
            }
            else if (double.TryParse(txtNumber.Text.Trim(), out number) && number != localNumber)
            {
                if(number < 24)
                    localNumber = number;
                localNumber = Math.Round(localNumber, 2);
                txtNumber.Text = localNumber == 0 ? "": localNumber.ToString();
                UpdateNumber?.Invoke();
            }
        }

        private void uLblTextbox_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                        e.Handled = true;
                }
                else
                    e.Handled = true;               
            }
            else
            {

                if (e.KeyChar <= 31)
                {
                    e.Handled = false;
                }
            }
        }

        internal void ClearText()
        {
            localNumber = 0;
            this.txtNumber.Text = "";
        }
    }
}
