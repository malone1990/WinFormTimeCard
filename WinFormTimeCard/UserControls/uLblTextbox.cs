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
        public uLblTextbox()
        {
            InitializeComponent();
        }

        public void InitUCInfo(string title, string day, double numbers) 
        {
            this.lblTitle.Text = title;
            this.lblDay.Text = day;
            localNumber = numbers;
            this.txtNumber.Text = numbers.ToString();
        }

        public double GetNumber() 
        {
            return localNumber;
        }

        private double localNumber = 0;
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            double number = 0;
            if (double.TryParse(txtNumber.Text.Trim(), out number) && number != localNumber)
            {
                if(number < 24)
                    localNumber = number;
                localNumber = Math.Round(localNumber, 2);
                txtNumber.Text = localNumber.ToString();
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
    }
}
