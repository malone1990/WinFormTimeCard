using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormTimeCard.Models;
using WinFormTimeCard.UserControls;

namespace WinFormTimeCard
{
    public partial class fmTimeCardMain : Form
    {
        private List<TimeEntryInfo> TimeEntries { get; set; }
        public TimeEntryInfo CurrentTimeEntry { get; set; }

        //public fmWeekPicker fmWeek = null;

        public fmTimeCardMain()
        {
            InitializeComponent();

            this.CreateMthCWeek();         
        }

        private void PnlHead_MouseClick(object sender, MouseEventArgs e)
        {
            if (mthCWeek.Visible && (e.X < pnlWeek.Location.X || e.X > pnlWeek.Location.X + pnlWeek.Width) &&
                    (e.Y < pnlWeek.Location.Y || e.Y > pnlWeek.Height))
            {
                mthCWeek.Hide();
            }
        }

        private void CreateMthCWeek()
        {
            //fmWeek = new fmWeekPicker();
            //fmWeek.DesktopLocation = new System.Drawing.Point(158, 188);

            this.mthCWeek = new MonthCalendar();
            this.mthCWeek.Location = new System.Drawing.Point(120, 175);
            this.mthCWeek.Name = "mthCWeek";
            this.mthCWeek.ShowToday = false;
            this.mthCWeek.FirstDayOfWeek = Day.Monday;
            this.mthCWeek.MouseLeave += new System.EventHandler(this.mthCWeek_MouseLeave);
            this.mthCWeek.DateSelected += MthCWeek_DateSelected;
            this.mthCWeek.DateChanged += MthCWeek_DateChanged;
            this.mthCWeek.BringToFront();
            this.grbTimeEntry.Controls.Add(this.mthCWeek);
            this.grbTimeEntry.Controls.SetChildIndex(this.mthCWeek, 0);
            mthCWeek.Hide();
        }

        

        private void fmTimeCardMain_Load(object sender, EventArgs e)
        {

            if (Common.CurrentUser != null)
            {
                lblcurName.Text = Common.CurrentUser.Name;
                lblRole.Text = Common.CurrentUser.IsAdmin ? "Admin" : "Staff";
                if (!Common.CurrentUser.IsAdmin)
                {
                    tpMain.TabPages.Remove(tabUsers);

                    this.btnAddUser.Visible = false;
                    this.btnDeleteUsers.Visible = false;
                }
                this.FreshUsersList();

                this.TimeEntries = Common.apiManager.GetTimeEntriesByUserId(Common.CurrentUserId);   
            }

            //tpMain.TabPages.Remove(tabUsers);

            UpdateSelectWeekByDate(DateTime.Now);
        }

        #region Users' Operation  
        private void FreshUsersList()
        {
            //lstvUsers.BindingContext = 

            lstvUsers.Items.Clear();
            List<UserInfo> users = Common.apiManager.GetAllUsers();
            if (users != null && users.Count > 0)
            {
                lstvUsers.BeginUpdate();
                ListViewItem item = null;
                foreach (var user in users)
                {
                    item = new ListViewItem(new string[] { user.Name, user.Address, user.Email, user.IsAdmin.ToString() });
                    item.Tag = user.UserId;
                    lstvUsers.Items.Add(item);
                }
                lstvUsers.EndUpdate();
            }
        }
        fmUserInfo register = null;
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (register == null)
            {
                register = new fmUserInfo();
                register.Owner = this;
            }

            if (DialogResult.OK == register.ShowDialog())
            {
                this.FreshUsersList();
            }
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            List<int> userIds = new List<int>();
            foreach (ListViewItem row in lstvUsers.Items)
            {
                if (row.Checked)
                {
                    userIds.Add(Convert.ToInt32(row.Tag));
                }
            }

            if(userIds.Count>0 && Common.apiManager.DeleteByUserIds(userIds.ToArray()))
            {
                this.FreshUsersList();
            }
        }
        #endregion
        /// <summary>
        /// to save current week info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// to add some timecards for current week info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtWeekShow_Click(object sender, EventArgs e)
        {
            if (!mthCWeek.Visible)
            {
                mthCWeek.Show();
                mthCWeek.Focus();
            }else
                mthCWeek.Hide();
        }

        private void mthCWeek_MouseLeave(object sender, EventArgs e)
        {
            mthCWeek.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UpdateSelectWeekByDate(CurrentTimeEntry.DateTo.AddDays(1));
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            UpdateSelectWeekByDate(CurrentTimeEntry.DateFrom.AddDays(-1));
        }

        private void UpdateSelectWeekByDate(DateTime date)
        {
            //fresh 
            btnSave.Enabled = false;
            btnSubmit.Enabled = false;


            var mon = WeekHelper.GetMondayDate(date);
            var sun = WeekHelper.GetSundayDate(date);
            lblWeekRange.Text = string.Format("{0}-{1}", mon.ToString("MM/dd/yyyy"), sun.ToString("MM/dd/yyyy"));
            mthCWeek.SetSelectionRange(mon, sun);

            if (TimeEntries != null && TimeEntries.Exists(t => t.DateFrom.Date.Equals(mon.Date) && t.DateTo.Date.Equals(sun.Date)))
            {
                CurrentTimeEntry = TimeEntries.Find(t => t.DateFrom.Date.Equals(mon.Date) && t.DateTo.Date.Equals(sun.Date));
                lblGlobalHours.Text = string.Format("Total {0} hrs", CurrentTimeEntry.TotalHours);

            }
            else
            {
                if (TimeEntries == null)
                    TimeEntries = new List<TimeEntryInfo>();

                CurrentTimeEntry = new TimeEntryInfo { UserId = Common.CurrentUserId, DateFrom = mon, DateTo = sun };
                TimeEntries.Add(CurrentTimeEntry);
                lblGlobalHours.Text = string.Format("Total {0} hrs", CurrentTimeEntry.TotalHours);
            }


            this.pnlTimeCards.Controls.Clear();
            this.pnlTimeCards.Controls.Add(btnAddCard);
            UCTimeCard ucTimeCard1 = new UCTimeCard();
            //ucTimeCard1.SetCombBoxProjects(new string[] { "1", "2" });
            ucTimeCard1.SetCombBoxProjects(Common.ProjectTypes, 0);

            ucTimeCard1.EventRemoveItemSelf += UcTimeCard1_EventRemoveItemSelf;
            ucTimeCard1.InitInfo(mon, new TimeCardInfo() { MonInfo = 1, WedInfo = 3.6 });
            //ucTimeCard1.Width = pnlTimeCards.Width - 2;
            ucTimeCard1.Dock = DockStyle.Top;
        
            this.pnlTimeCards.Controls.Add(ucTimeCard1);
            this.pnlTimeCards.Controls.SetChildIndex(ucTimeCard1, 0);
            
            //this.ucTimeCard1.SetCombBoxProjects(new string[] { "1","2"});
        }

        private void UcTimeCard1_EventRemoveItemSelf(Control ctl)
        {
            ctl.Parent.Controls.Remove(ctl);
            ctl.Dispose();          
        }

        private void CreateNewCard(DateTime mon, int selectedProType)
        {
            int index = pnlTimeCards.Controls.IndexOf(btnAddCard);
            UCTimeCard ucTimeCard1 = new UCTimeCard();    
            ucTimeCard1.SetCombBoxProjects(Common.ProjectTypes, selectedProType);

            ucTimeCard1.InitInfo(mon, new TimeCardInfo() { MonInfo = 0, WedInfo = 0 });
            ucTimeCard1.Dock = DockStyle.Top;
            this.pnlTimeCards.Controls.Add(ucTimeCard1);
            this.pnlTimeCards.Controls.SetChildIndex(ucTimeCard1, index);
        }

        private void MthCWeek_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateSelectWeekByDate(e.Start);
        }

        private void MthCWeek_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (e.Start != e.End)
            {

                if (!WeekHelper.IsInSameWeek(e.Start, e.End))
                {
                    if (e.Start.Day != 1)
                        UpdateSelectWeekByDate(e.Start);
                    else
                        UpdateSelectWeekByDate(e.End);                  
                }
            }
        }

        private void btnCloneLastWeek_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            this.CreateNewCard(CurrentTimeEntry.DateFrom, 0);
        }

        private void btnNoSickLv_Click(object sender, EventArgs e)
        {
            this.CreateNewCard(CurrentTimeEntry.DateFrom, Array.IndexOf(Common.ProjectTypes,"No-Sick Leave"));
        }

        private void btnScikLv_Click(object sender, EventArgs e)
        {
            this.CreateNewCard(CurrentTimeEntry.DateFrom, Array.IndexOf(Common.ProjectTypes, "Sick Leave"));
        }

       
    }
}
