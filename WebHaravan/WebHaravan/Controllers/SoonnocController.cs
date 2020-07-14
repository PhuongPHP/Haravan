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
            Welcome haravan = List();
        
            return View(haravan);
        }
        [Authorize]
        public ActionResult TaoDonHang()
        {
            return View();
        }

        private Welcome List()
        {
            string data = string.Empty;
            string WEBSERVICE_URL = "https://apis.haravan.com/com/orders.json";

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