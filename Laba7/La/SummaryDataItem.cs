using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_zag
{
    internal class SummaryDataItem
    {
        public string GroupName { get; set; }      // Название товарной группы
        public float AveragePurchasePrice { get; set; } // Средняя цена закупки по группе
        public float TotalProfit { get; set; }     // Суммарная прибыль по группе
    }
}
