using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDeveloper.InAndOutModel
{
    public class MFilterBase
    {
        public MSort Sort { get; set; } = new MSort();
        public string url { get; set; }    
        public int Offset { get; set; } = 0;

        public int Take { get; set; } = 10;

        public string Search { get; set; } = string.Empty;
    }

    public class MSort
    {
        public string Column { get; set; } = "Name";

        public string Type { get; set; } = "DESC";
    }
}
