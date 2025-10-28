using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_zag
{
    internal class RowDataItem
    {
        public string Name { get; set; }           // Наименование товара
        public string Group { get; set; }          // Товарная группа (строка)
        public float PurchasePrice { get; set; }   // Цена закупки
        public float SalePrice { get; set; }       // Цена продажи

        public float Profit                        // Прибыль с единицы товара
        {
            get { return SalePrice - PurchasePrice; }
        }

        public float TotalProfit                   // Общая прибыль (если нужно для количества)
        {
            get { return Profit; } // В задании нет количества, поэтому равно Profit
        }
    }
}
