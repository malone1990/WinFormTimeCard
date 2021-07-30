using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using WinFormTimeCard.Models;

namespace WinFormTimeCard.UserControls
{
    public partial class UCTimeCard : UserControl
    {
        public delegate void DelegateRemoveItemSelf(Control ctl);
        public event DelegateRemoveItemSelf EventRemoveItemSelf = null;

        private uLblTextbox[] ctlWeeks = new uLblTextbox[7];
        public UCTimeCard()
        {
            InitializeComponent();
            for (int i = 0; i < ctlWeeks.Length; i++)
            {
                ctlWeeks[i] = new uLblTextbox();
                
                this.flowLayoutPanel1.Controls.Add(ctlWeeks[i]);
            }
        }

        public void UpdateTimecardTimes()
        {
            double sum = 0;
            Array.ForEach(ctlWeeks, t => sum += t.GetNumber());
            this.lblTotal.Text = string.Format("{0} Hours", Math.Round(sum, 2));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void UCTimeCard_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Width = this.Parent.Width - 200;
            this.btnDelete.Location = new Point(this.Parent.Width - 120, btnDelete.Location.Y);
            this.lblTotal.Location = new Point(this.Parent.Width - 240, this.lblTotal.Top);
            this.btnClear.Location = new Point(this.Parent.Width - 120, btnClear.Location.Y);
            this.Height = 220;


        }

        public void SetCombBoxProjects(string[] items, int selectd = 0) 
        {
            this.cmbProjects.Items.Clear();
            this.cmbProjects.DataSource = items;
            this.cmbProjects.SelectedIndex = selectd;
            //this.cmbProjects.Items.AddRange(items);
        }

        public void InitInfo(DateTime mon, TimeCardInfo timeCard) 
        {
            List<Tuple<string, DateTime, double>> tuples = new List<Tuple<string, DateTime, double>>();
            tuples.Add(new Tuple<string, DateTime, double>("Mon", mon, timeCard.MonInfo));
            tuples.Add(new Tuple<string, DateTime, double>("Tue", mon.AddDays(1), timeCard.TueInfo));
            tuples.Add(new Tuple<string, DateTime, double>("Wed", mon.AddDays(2), timeCard.WedInfo));
            tuples.Add(new Tuple<string, DateTime, double>("Thu", mon.AddDays(3), timeCard.ThuInfo));
            tuples.Add(new Tuple<string, DateTime, double>("Fri", mon.AddDays(4), timeCard.FriInfo));
            tuples.Add(new Tuple<string, DateTime, double>("Sat", mon.AddDays(5), timeCard.SatInfo));
            tuples.Add(new Tuple<string, DateTime, double>("Sun", mon.AddDays(6), timeCard.SunInfo));

            for(int i = 0; i< ctlWeeks.Length;i++)
            {
                ctlWeeks[i].UpdateNumber += UpdateTimecardTimes;
                ctlWeeks[i].InitUCInfo(tuples[i].Item1, tuples[i].Item2.ToString("MMM dd",CultureInfo.CreateSpecificCulture("en-GB")), tuples[i].Item3
                    , DateTime.Now.Date.Equals(tuples[i].Item2.Date));
            }

            this.lblTotal.Text = string.Format("{0} Hours", timeCard.Count);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (EventRemoveItemSelf != null)
                EventRemoveItemSelf?.Invoke(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.ForEach(ctlWeeks, ctl => ctl.ClearText());
            this.lblTotal.Text = "0 Hours";
        }
    }
}
