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
        public ActionResult TatCaDonHang(int? page)
        {
            int? pageNumber = page != null ? page : 1;
            Welcome haravan = List(pageNumber);
            var count_page = Page();
            JObject objectPage = JObject.Parse(count_page);
            var count = objectPage["count"];
            int totalPage = 0;
            int page_du = (int)count % 20;
            if (page_du == 0)
            {
                totalPage = (int)count / 20;
            }
            if (page_du != 0)
            {
                totalPage = (int)count / 20 + 1;
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
        [HttpPost]
        public ActionResult Order(int page)
        {
            int pageNumber = page;
            Welcome haravan = List(pageNumber);
            var count_page = Page();
            JObject objectPage = JObject.Parse(count_page);
            var count = objectPage["count"];
            int totalPage = 0;
            int page_du = (int)count % 20;
            if (page_du == 0)
            {
                totalPage = (int)count / 20;
            }
            if (page_du != 0)
            {
                totalPage = (int)count / 20 + 1;
            }
            return PartialView("~/Views/Soonnoc/_PartialOrderAll.cshtml", haravan);
        }
        [HttpPost]
        public ActionResult Notfulfilled(int page)
        {
            int pageNumber = page;
            Welcome haravan = List(pageNumber);
            var count_page = Page();
            JObject objectPage = JObject.Parse(count_page);
            var count = objectPage["count"];
            int totalPage = 0;
            int page_du = (int)count % 20;
            if (page_du == 0)
            {
                totalPage = (int)count / 20;
            }
            if (page_du != 0)
            {
                totalPage = (int)count / 20 + 1;
            }
            return PartialView("~/Views/Soonnoc/_PartialOrderAll.cshtml", haravan);
        }
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



        private Welcome List(int? value)
        {
            try
            {
                Welcome modelresult = new Welcome();
                string data = string.Empty;
                string WEBSERVICE_URL = "https://apis.haravan.com/com/orders.json?page=";
                //string WEBSERVICE_URL = "https://apis.haravan.com/com/orders.json?page=1&limit=20";
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL + value + "&limit=20");

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