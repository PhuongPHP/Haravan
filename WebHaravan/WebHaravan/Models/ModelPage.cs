using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHaravan.Models
{
    public class ModelPage
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }
}