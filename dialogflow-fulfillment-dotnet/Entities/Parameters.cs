using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogFlow.Fulfillment.Dotnet.Entities
{
    public class Parameters
    {
        [JsonProperty("param")]
        public string Param { get; set; }
    }
}
