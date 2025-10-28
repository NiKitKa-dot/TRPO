using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_U
{
    internal class RowDataItem
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public string Part { get; set; }
        public float Price { get; set; }
        public float Count { get; set; }

        public float Sum
        {
            get { return Count * Price; }
        }
    }
}