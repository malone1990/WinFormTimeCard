using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormTimeCard.UserControls
{
    public partial class fmWeekPicker : Form
    {
        public delegate void DelegateUpdatePicker(DateTime mon, DateTime sun);

        public DelegateUpdatePicker delegateUpdatePicker;

        public fmWeekPicker()
        {
            InitializeComponent();
            var mon = GetMondayDate(DateTime.Now);

            mthcWeekPicker.AddBoldedDate(mon);
            mthcWeekPicker.AddBoldedDate(mon.AddDays(1));
            mthcWeekPicker.AddBoldedDate(mon.AddDays(2));
            mthcWeekPicker.AddBoldedDate(mon.AddDays(3));
            mthcWeekPicker.AddBoldedDate(mon.AddDays(4));
            mthcWeekPicker.AddBoldedDate(mon.AddDays(5));
            mthcWeekPicker.AddBoldedDate(mon.AddDays(6));
        }



        private void monthCalendar1_MouseLeave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateSelectWeekByDate(DateTime date)
        {
            var mon = GetMondayDate(date);
            var sun = GetSundayDate(date);
            mthcWeekPicker.SetSelectionRange(mon, sun);
            delegateUpdatePicker(mon, sun);
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateSelectWeekByDate(e.Start);
           
            //if (IsInSameWeek(e.Start, e.End))
            //{

            //}
            //else
            //{
            //    if (e.Start.DayOfWeek < e.End.DayOfWeek)
            //        UpdateSelectWeekByDate(e.Start);
            //    else
            //        UpdateSelectWeekByDate(e.End);
            //}
        }

        private void mthcWeekPicker_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (e.Start != e.End)
            {
                //if (e.Start.Day == 1)
                //{
                //    mthcWeekPicker.SetSelectionRange(e.End, e.Start);
                //}

                if (!IsInSameWeek(e.Start, e.End))
                {
                    //UpdateSelectWeekByDate(e.Start);
                    //if (e.Start.DayOfWeek < e.End.DayOfWeek)
                    if (e.Start.Day != 1)
                        UpdateSelectWeekByDate(e.Start);
                    else
                        UpdateSelectWeekByDate(e.End);
                    //else
                    //    UpdateSelectWeekByDate(e.End);
                    //isSelected = false;
                }
            }
        }

        private bool IsInSameWeek(DateTime dtmS, DateTime dtmE)
        {
            TimeSpan ts = dtmE - dtmS;
            double dbl = ts.TotalDays;
            int intDow = Convert.ToInt32(dtmE.DayOfWeek);
            if (intDow == 0) intDow = 7;
            if (dbl >= 7 || dbl >= intDow) return false;
            else return true;
        }

        public  DateTime GetMondayDate(DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Monday;
            if (i == -1) i = 6;// i值 > = 0 ，因为枚举原因，Sunday排在最前，此时Sunday-Monday=-1，必须+7=6。
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Subtract(ts);
        }
        /// 
        /// 计算某日结束日期（礼拜日的日期）
        /// 
        /// 该周中任意一天
        /// 返回礼拜日日期，后面的具体时、分、秒和传入值相等
        public  DateTime GetSundayDate(DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Sunday;
            if (i != 0) i = 7 - i;// 因为枚举原因，Sunday排在最前，相减间隔要被7减。
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Add(ts);
        }
    }
}
