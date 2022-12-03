using System.Collections.Generic;

namespace SimpleDeveloper.InAndOutModel
{
    public class ResponseBase<T>
    {
        public int Status { get; set; } = 200;

        public string StatusText { get; set; }

        public List<string> StatusTexts { get; set; } = new List<string>();
        public T Item { get; set; }

        public dynamic Total { get; set; }

        public long Count { get; set; } = 0;
    }
}
