using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormTimeCard.Models;

namespace WinFormTimeCard.Services
{
    public class MockTimeCardRepo : ITimeCardRepo
    {
        private MockTimeCardRepo()
        { 
                UserInfos = InitUsers();

        }

        private static MockTimeCardRepo manager;

        public static MockTimeCardRepo GetManager()
        {
            if (manager == null)
            {
                manager = new MockTimeCardRepo();
            }
            return manager;
        }

        private List<UserInfo> UserInfos = null;
        public UserInfo CurrentUser = null;
        public List<UserInfo> InitUsers() {
            var UserInfos = new List<UserInfo>();
            UserInfos.Add(new UserInfo { UserId=  1, Name = "tset1", Password = "djwe", IsAdmin = false});
            UserInfos.Add(new UserInfo { UserId = 2, Name = "admin", Password = "admin", IsAdmin = true });
            UserInfos.Add(new UserInfo { UserId = 3, Name = "s23232", Password = "222222", IsAdmin = false });

            return UserInfos;
        }

        #region user
        bool ITimeCardRepo.DeleteByUserIds(int[] userIds)
        {
            if (UserInfos.Any(user => userIds.Contains(user.UserId)))
                return UserInfos.RemoveAll(user => userIds.Contains(user.UserId)) > 0;
            else
                return 0 >= 1;
        }

        List<UserInfo> ITimeCardRepo.GetAllUsers()
        {
            if (CurrentUser != null && !UserInfos.Contains(CurrentUser))
                UserInfos.Add(CurrentUser);

            return UserInfos;
        }

        ResultInfo ITimeCardRepo.LoginByNameAndPwd(string name, string password)
        {
            var user = UserInfos.FirstOrDefault(user=>user.Name == name && user.Password == password);
            if (user == null)
                CurrentUser = new UserInfo { UserId = 0, Name = name, Password = password };
            else
                CurrentUser = user;

            string json = JsonHelper.SerializeObject(CurrentUser);            
            return new ResultInfo { ResultCode="200",ResultMessage="Login Successfully", ResultData= json};
        }

        bool ITimeCardRepo.Register(UserInfo userInfo)
        {
            UserInfos.Add(userInfo);
            return true;
        }
        #endregion

        #region TimeCard

        List<TimeEntryInfo> ITimeCardRepo.GetTimeEntriesByUserId(int userId)
        {
            var user = new UserInfo { UserId = userId, Name = "test" };
            var TimeCard = new TimeCardInfo { TiemCardId = 0, TimeEntryId = 0, MonInfo = 8, ThuInfo = 4.0, FriInfo = 4.5, WedInfo = 3.8 };
            var entry1 = new TimeEntryInfo() { User = user, DateFrom = DateTime.Parse("2021-7-12"), DateTo = DateTime.Parse("2021-7-18"), TimeEntryId = 0 };
            var entry2 = new TimeEntryInfo() { User = user, DateFrom = DateTime.Parse("2021-7-19"), DateTo = DateTime.Parse("2021-7-25"), TimeEntryId = 1 };
            var entry3 = new TimeEntryInfo() { User = user, DateFrom = DateTime.Parse("2021-7-26"), DateTo = DateTime.Parse("2021-8-01"), TimeEntryId = 3 };
            return new List<TimeEntryInfo> { entry1, entry2, entry3 };
        }

        #endregion
    }
}
