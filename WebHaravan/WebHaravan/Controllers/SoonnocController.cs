using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
//using QuickType;
using WebHaravan.Models.Soonnoc;
using static WebHaravan.Common.ContantSoonnoc;


namespace WebHaravan.Controllers
{
    public class SoonnocController : Controller
    {
        // GET: Soonnoc
        [Authorize]
        public ActionResult TatCaDonHang()
        {
            Welcome count_page = Page();

   
            var count = count_page.Count;
            Console.WriteLine(count);
            int page_du = (int)count % 50;
            int total_page = 0;
            if (page_du == 0)
            {
                total_page = (int)count / 50;
            }
            if (page_du != 0)
            {
                total_page = (int)count / 50 + 1;
            }
            total_page = count_page.TotalPage;
            Welcome haravan = List();
            return View(total_page);
        }
        [Authorize]
        public ActionResult TaoDonHang()
        {
            return View();
        }

        private Welcome List()
        {
            try
            {
               
                //JObject objectPage = JObject.Parse(count_page);
                //var count = objectPage["count"];
                //int page_du = (int)count % 50;
                //int page = 0;
                //if (page_du == 0)
                //{
                //    page = (int)count / 50;
                //}
                //if (page_du != 0)
                //{
                //    page = (int)count / 50 + 1;
                //}
                Welcome modelresult = new Welcome();
                //for (int i = 0; i <= page; i++)
                //{
                    string data = string.Empty;
                    string WEBSERVICE_URL = "https://apis.haravan.com/com/orders.json";
                    System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                    var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);

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
                //}
                return modelresult;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public Welcome Page()
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