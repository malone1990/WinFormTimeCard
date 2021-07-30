using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WinFormTimeCard.Models;
using WinFormTimeCard.Services;

namespace WinFormTimeCard
{
    public class Common
    {
        public static ITimeCardRepo apiManager = null; 

        public static UserInfo CurrentUser = null;

        public static int CurrentUserId;

        public static string[] ProjectTypes = new string[] { "Project Test1",
                                                            "Project Test2",
                                                            "Project Test3",
                                                            "No-Sick Leave",
                                                            "Sick Leave"};

    }
}

