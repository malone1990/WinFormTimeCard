using System;
using System.IO;
using System.Configuration;
using System.Text;
using System.Net;
using WinFormTimeCard.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WinFormTimeCard.Services
{
    public class ApiManager
    {
        private ApiManager() { }

        private static ApiManager manager;

        public static ApiManager GetManager() { 
        if(manager == null)
            {
                manager = new ApiManager();
            }
            return manager;
        }

        //private readonly string _hostAddress = ConfigurationManager.AppSettings["HostAddress"].TrimEnd('/');
        private readonly string _hostAddress = Array.Exists(ConfigurationManager.AppSettings.AllKeys, (t => t == "HostAddress")) ? 
                                                            ConfigurationManager.AppSettings["HostAddress"].TrimEnd('/') : "localhost:5001";

        #region User
        /// <summary>
        /// Get Login By Name And Pwd
        /// </summary>
        /// <returns></returns>
        public ResultInfo LoginByNameAndPwd(string name,string password) 
        {
            ResultInfo info = null;
            try {
                WebClient client = new WebClient();
                string uri = string.Format("https://{0}/user/login?name={1}&password={2}", _hostAddress, name, password);
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Content-Type", "application/json");
                Console.WriteLine(uri);
                string result = client.DownloadString(uri);

                if (!string.IsNullOrEmpty(result))
                    info = JsonHelper.DeserializeJsonToObject<ResultInfo>(result);
            }
            catch (Exception ex)
            {
                info = new ResultInfo() { ResultCode = "300", ResultMessage = ex.Message };
            }
            return info != null? info : new ResultInfo() { ResultCode="300", ResultMessage="Unkown Errors."};
        }

        /// <summary>
        /// Get Login By Name And Pwd
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetAllUsers()
        {
            List<UserInfo> list = null;
            try { 
                WebClient client = new WebClient();
                string uri = string.Format("https://{0}/user/users", _hostAddress);
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Content-Type", "application/json");
                string result = client.DownloadString(uri);

            
                if (!string.IsNullOrEmpty(result))
                    list = JsonHelper.DeserializeJsonToList<UserInfo>(result);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public bool Register(UserInfo userInfo)
        {
            bool answer = false;
            try
            {
                WebClient client = new WebClient();
                string uri = string.Format("https://{0}/user/user", _hostAddress);
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Content-Type", "application/json");

                var json = JsonHelper.SerializeObject(userInfo);
                string result = client.UploadString(uri, "Post", json);

                answer = Convert.ToBoolean(result);
                //if (!string.IsNullOrEmpty(result))
                //    list = JsonHelper.DeserializeJsonToList<UserInfo>(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return answer;
        }

        public bool DeleteByUserIds(int[] userIds)
        {
            bool answer = false;
            try
            {
                
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(string.Format("https://{0}", _hostAddress));
                // 为JSON格式添加一个Accept报头
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync(string.Format("user/user/{0}", string.Join(',', userIds))).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    answer = Convert.ToBoolean(result);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return answer;
        }
        #endregion

        #region TimeCard
        public List<TimeEntryInfo> GetTimeEntriesByUserId(int userId) 
        {
            List<TimeEntryInfo> list = null;
            try
            {
                WebClient client = new WebClient();
                string uri = string.Format("https://{0}/timecard/entry/{1}", _hostAddress, userId);
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Content-Type", "application/json");
                string result = client.DownloadString(uri);


                if (!string.IsNullOrEmpty(result))
                    list = JsonHelper.DeserializeJsonToList<TimeEntryInfo>(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }


        #endregion

    }
}
