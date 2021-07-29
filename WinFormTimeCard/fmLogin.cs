using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTimeCard.Models;

namespace WinFormTimeCard
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Name Or Password is Null!");
                return;            
            }

            ResultInfo result = Common.apiManager.LoginByNameAndPwd(txtName.Text.Trim(), txtPassword.Text.Trim());

            if (result != null)
                MessageBox.Show(result.ResultMessage);

            if (result.ResultCode == "200")
            {
                Common.CurrentUser = JsonHelper.DeserializeJsonToObject<UserInfo>( result.ResultData.ToString());
                Common.CurrentUserId = Common.CurrentUser != null ?Common.CurrentUser.UserId:-1;

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
