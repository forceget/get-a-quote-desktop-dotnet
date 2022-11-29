using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDeveloper.InAndOutModel
{
    public class ResponseBase<T>
    {
        public int Status { get; set; } = 200;

        public string StatusText { get; set; }

        public List<string> StatusTexts { get; set; } = new List<string>();
        [JsonProperty("item")]
        public T Item { get; set; }

        public dynamic Total { get; set; }

        public long Count { get; set; } = 0;
    }
}
