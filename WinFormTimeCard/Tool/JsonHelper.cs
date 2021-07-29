using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

//using System.Web.Script.Serialization;


namespace WinFormTimeCard
{
    public class JsonHelper
    {
        /// <summary>
        /// 将对象序列化为JSON格式
        /// </summary>
        /// <param name="o">对象</param>
        /// <returns>json字符串</returns>
        public static string SerializeObject(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;
        }

        /// <summary>
        /// 解析JSON字符串生成对象实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串(eg.{"ID":"112","Name":"石子儿"})</param>
        /// <returns>对象实体</returns>
        public static T DeserializeJsonToObject<T>(string json) where T : class
        {
            try
            {
                if (json != null)
                {
                    JsonSerializer serializer = new JsonSerializer();
                    using (StringReader sr = new StringReader(json))
                    using (JsonTextReader reader = new JsonTextReader(sr))
                    {
                        object o = serializer.Deserialize(reader, typeof(T));
                        T t = o as T;
                        return t;
                    }
                }
            }
            catch (Exception ex)
            {
                //LogHelper.Error("解析JSON",ex);
                return null;
            }

            return null;

        }

        /// <summary>
        /// 解析JSON数组生成对象实体集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json数组字符串(eg.[{"ID":"112","Name":"石子儿"}])</param>
        /// <returns>对象实体集合</returns>
        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            try
            {
                if (json != null)
                {
                    JsonSerializer serializer = new JsonSerializer();
                    using (StringReader sr = new StringReader(json))
                    using (JsonTextReader reader = new JsonTextReader(sr))
                    {
                        object o = serializer.Deserialize(reader, typeof(List<T>));
                        List<T> list = o as List<T>;
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        /// <summary>
        /// 反序列化JSON到给定的匿名对象.
        /// </summary>
        /// <typeparam name="T">匿名对象类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <param name="anonymousTypeObject">匿名对象</param>
        /// <returns>匿名对象</returns>
        public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
        {

            T t = JsonConvert.DeserializeAnonymousType(json, anonymousTypeObject);
            return t;

        }

        //public static Dictionary<string, object> JsonToDictionary(string jsonData)
        //{
        //    //实例化JavaScriptSerializer类的新实例
        //    JavaScriptSerializer jss = new JavaScriptSerializer();
        //    try
        //    {
        //        //将指定的 JSON 字符串转换为 Dictionary<string, object> 类型的对象
        //        return jss.Deserialize<Dictionary<string, object>>(jsonData);
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

    }

}
