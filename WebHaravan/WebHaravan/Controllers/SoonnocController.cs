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
using PagedList;
using PagedList.Mvc;
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
            int pageSize = 20;
            int pageNumber = page ?? 1;
            List<Welcome> haravan = List().ToList();
            var count_page = Page();
            JObject objectPage = JObject.Parse(count_page);
            var count = objectPage["count"];
            int page_du = (int)count % 50;
            if (page_du == 0)
            {
                page = (int)count / 50;
            }
            if (page_du != 0)
            {
                page = (int)count / 50 + 1;
            }
            return View(haravan[pageNumber].Order.ToList().OrderBy(m => m.OrderNumber).ToPagedList(pageNumber, pageSize));
            //return View(haravan.Order.ToList().OrderBy(m=>m.OrderNumber).ToPagedList(pageNumber, pageSize));
        }
        [Authorize]
        public ActionResult TaoDonHang()
        {
            return View();
        }

        private List<Welcome> List()
        {
            try
            {
                var count_page = Page();
                JObject objectPage = JObject.Parse(count_page);
                var count = objectPage["count"];
                int page_du = (int)count % 50;
                int page = 0;
                if (page_du == 0)
                {
                    page = (int)count / 50;
                }
                if (page_du != 0)
                {
                    page = (int)count / 50 + 1;
                }
                Welcome modelresult = new Welcome();
                List<Welcome> listmodel = new List<Welcome>();
                for (int i = 0; i <= page; i++)
                {
                    string data = string.Empty;
                    string WEBSERVICE_URL = "https://apis.haravan.com/com/orders.json?page=";
                    System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                    var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL + i);

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
                        listmodel.Add(modelresult);
                    }
                }
                return listmodel;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
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
    }
}