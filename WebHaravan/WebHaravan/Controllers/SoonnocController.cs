using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebHaravan.Models.Soonnoc;
using static WebHaravan.Common.ContantSoonnoc;



namespace WebHaravan.Controllers
{
    public class SoonnocController : Controller
    {
        // GET: Soonnoc
        [Authorize]
        public ActionResult TatCaDonHang(/*int pageNumber = 1*/ int? page)
        {
            //string data = List(pageNumber);
            //var modelresult = JsonConvert.DeserializeObject<Welcome>(data);
            //if (pageNumber == 1)
            //{
            //    Welcome modelPage = new Welcome();
            //    string pageApi = Page();
            //    JObject objectPage = JObject.Parse(pageApi);
            //    var count = objectPage["count"];
            //    int page_du = (int)count % 50;
            //    int totalPage = 0;
            //    if (page_du == 0)
            //    {
            //        totalPage = (int)count / 50;
            //    }
            //    if (page_du != 0)
            //    {
            //        totalPage = (int)count / 50 + 1;
            //    }
            //    modelresult.PageCount = (long)count;
            //    modelresult.TotalPage = totalPage;
            //    modelresult.PageNumber = pageNumber;
            //}
            //if(pageNumber != 1)
            //{
            //    Welcome modelPage = new Welcome();
            //    string pageApi = Page();
            //    JObject objectPage = JObject.Parse(pageApi);
            //    var count = objectPage["count"];
            //    int page_du = (int)count % 50;
            //    int totalPage = 0;
            //    if (page_du == 0)
            //    {
            //        totalPage = (int)count / 50;
            //    }
            //    if (page_du != 0)
            //    {
            //        totalPage = (int)count / 50 + 1;
            //    }
            //    modelresult.PageCount = (long)count;
            //    modelresult.TotalPage = totalPage;
            //    modelresult.PageNumber = pageNumber;

            //    return PartialView("~/Views/Soonnoc/_PartialOrderAll.cshtml", modelresult);
            //}
            //return View(modelresult);
            int pageSize = 50;
            int pageNumber = page ?? 1;
            Welcome haravan = List(pageNumber);
            var count_page = Page();
            JObject objectPage = JObject.Parse(count_page);
            var count = objectPage["count"];
            int totalPage = 0;
            int page_du = (int)count % 50;
            if (page_du == 0)
            {
                totalPage = (int)count / 50;
            }
            if (page_du != 0)
            {
                totalPage = (int)count / 50 + 1;
            }
            haravan.PageCount = (long)count;
            haravan.TotalPage = totalPage;
            haravan.PageNumber = pageNumber;
            return View(haravan);
        }
        [Authorize]
        public ActionResult TaoDonHang()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Order(int page)
        //{
        //    string data = List(page);
        //    var modelresult = JsonConvert.DeserializeObject<Welcome>(data);
        //    if (page != 1)
        //    {
        //        Welcome modelPage = new Welcome();
        //        string pageApi = Page();
        //        JObject objectPage = JObject.Parse(pageApi);
        //        var count = objectPage["count"];
        //        int page_du = (int)count % 50;
        //        if (page_du == 0)
        //        {
        //            page = (int)count / 50;
        //        }
        //        if (page_du != 0)
        //        {
        //            page = (int)count / 50 + 1;
        //        }
        //        modelresult.PageCount = (long)count;
        //        modelresult.TotalPage = (int)page;
        //    }
        //    return PartialView("~/Views/Soonnoc/_PartialOrderAll.cshtml", modelresult);
        //}
        //private string List(int value)
        //{
        //    try
        //    {
        //            string data = string.Empty;
        //            string WEBSERVICE_URL = "https://apis.haravan.com/com/orders.json?page=";
        //            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
        //            var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL + value);
        //            if (webRequest != null)
        //            {
        //                webRequest.Method = "GET";
        //                webRequest.Timeout = 20000;
        //                webRequest.Headers.Add(Header.AppId, Header.AppIdValue);
        //                var httpResponse = (HttpWebResponse)webRequest.GetResponse();
        //                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //                {
        //                    string request = streamReader.ReadToEnd();
        //                    data = request;
        //                }
        //        }
        //        return data;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        return null;
        //    }
        //}
        public string Page()
        {
            string data = string.Empty;
            string WEBSERVICE_URL = "https://apis.haravan.com/com/orders/count.json";

            try
            {
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                Welcome modelresult = new Welcome();
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 20000;
                    webRequest.Headers.Add(Header.AppId, Header.AppIdValue);
                    var httpResponse = (HttpWebResponse)webRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        string request = streamReader.ReadToEnd();
                        data = request;
                        
                    }
                    modelresult = JsonConvert.DeserializeObject<Welcome>(data);
                }
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }



        private Welcome List(int varlue)
        {
            try
            {
                Welcome modelresult = new Welcome();
                    string data = string.Empty;
                    string WEBSERVICE_URL = "https://apis.haravan.com/com/orders.json?page=";
                    System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                    var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL + varlue);

                    if (webRequest != null)
                    {
                        webRequest.Method = "GET";
                        webRequest.Timeout = 20000;
                        webRequest.Headers.Add(Header.AppId, Header.AppIdValue);
                        var httpResponse = (HttpWebResponse)webRequest.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            string request = streamReader.ReadToEnd();
                            data = request;
                        }
                        modelresult = JsonConvert.DeserializeObject<Welcome>(data);
                    }
                return modelresult;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}