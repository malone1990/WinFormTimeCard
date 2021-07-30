using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormTimeCard.Services;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormTimeCard.Models;

namespace WinFormTimeCard.Services.Tests
{
    [TestClass()]
    public class ApiManagerTests
    {
        ITimeCardRepo apiManager = ApiManager.GetManager();

        [TestMethod()]
        public void LoginByNameAndPwdTest()
        {
            ResultInfo result = apiManager.LoginByNameAndPwd("admin", "admin");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ResultCode, "200");
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetAllUsersTest()
        {
            List<UserInfo> users = apiManager.GetAllUsers();
            Assert.IsNotNull(users);
            //Assert.IsTrue(users.Count > 0);
        }

        [TestMethod()]
        public void RegisterTest()
        {
            UserInfo user = new UserInfo() { Name = "test" + new Random(1000).Next(), Password = "123456", IsAdmin = false };
            var result = apiManager.Register(user);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void DeleteByUserIdsTest()
        {
            int[] userIds = new int[] { 1, 2};
            var result = apiManager.DeleteByUserIds(userIds);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GetTimeEntriesByUserIdTest()
        {
            List<TimeEntryInfo> users = apiManager.GetTimeEntriesByUserId(0);
            Assert.IsNotNull(users);
        }
    }
}