using System;
using System.Collections.Generic;
using System.Text;
using WinFormTimeCard.Models;

namespace WinFormTimeCard.Services
{
    public interface ITimeCardRepo
    {
        #region User
        ResultInfo LoginByNameAndPwd(string name, string password);

        List<UserInfo> GetAllUsers();

        bool Register(UserInfo userInfo);

        bool DeleteByUserIds(int[] userIds);
        #endregion

        #region TimeCard
        List<TimeEntryInfo> GetTimeEntriesByUserId(int userId);
        #endregion
    }
}
