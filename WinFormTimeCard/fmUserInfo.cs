using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormTimeCard.Models;

namespace WinFormTimeCard
{
    public partial class fmUserInfo : Form
    {
        public fmUserInfo()
        {
            InitializeComponent();
        }

        private void fmUserInfo_Load(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            chkIsAmdin.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (!ValidateTextbox(out errorMessage))
            {
                MessageBox.Show(errorMessage,"Some Errors", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            UserInfo user = new UserInfo() { Name = txtName.Text.Trim(), Password = txtPassword.Text.Trim(),
                                            Address = txtAddress.Text.Trim(), Email = txtEmail.Text.Trim(), IsAdmin = chkIsAmdin.Checked };
            var result = Common.apiManager.Register(user);
            if (result)
            {
                MessageBox.Show("Success to Resiger!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }else
                MessageBox.Show("Fail to Resiger!");
        }


        private bool ValidateTextbox(out string errorMessage) 
        {
            errorMessage = string.Empty;
            bool result = false;
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorMessage = "Please input the name!";
                return result;
            }
            else if (!IsValidUserName(txtName.Text.Trim()))
            {
                errorMessage = "Limit the length (4-20 characters) and content of the user name "
                    + "(only Chinese characters, letters, underscores, numbers)!";
                return result;
            }

            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorMessage = "Please input the password!";
                return result;
            }
            else if (!IsValidUserName(txtPassword.Text.Trim()))
            {
                errorMessage = "Limit the length (6-16 characters) and content of the secret "
                    + "(only letters, underscores, numbers)";
                return result;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !IsValidEmail(txtEmail.Text.Trim()))
            {
                errorMessage = "Please make sure the email is useful!";
                return result;
            }

            result = true;
            return result;
        }



        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public static int GetStringLength(string stringValue)
        {
            return Encoding.Default.GetBytes(stringValue).Length;
        }  

        /// <summary>
        /// [4,20] char, _ ,number and chinese word
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static bool IsValidUserName(string userName)
        {
            int userNameLength = GetStringLength(userName);
            if (userNameLength >= 4 && userNameLength <= 20 && Regex.IsMatch(userName, @"^([\u4e00-\u9fa5A-Za-z_0-9]{0,})$"))
            {   
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// [6,16] only number,char and _ 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^[A-Za-z_0-9]{6,16}$");
        }

       
    }

    public static class Validator
    {

        static Regex ValidEmailRegex = CreateValidEmailRegex();

        /// <summary>
        /// Taken from http://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx
        /// </summary>
        /// <returns></returns>
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
    }
}
