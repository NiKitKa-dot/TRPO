using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_zag
{
    interface DataInterface
    {
        List<RowDataItem> GetRowData();
        List<SummaryDataItem> GetSummaryData();
        float GetTotalProfit(); // Новый метод для общей прибыли
    }

    internal class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rowData == null) return false;
                else return true;
            }
        }

        private List<RowDataItem> rowData;
        private List<SummaryDataItem> summaryData;
        private float totalProfit; // Общая прибыль по всем товарам
        private char devider = '%';
        private DataStorage() { }

        private void BuildSummary()
        {
            // Словарь для хранения данных по группам
            Dictionary<string, (float totalPurchase, float totalProfit, int count)> groupData =
                new Dictionary<string, (float, float, int)>();

            totalProfit = 0; // Обнуляем общую прибыль

            foreach (var item in rowData)
            {
                totalProfit += item.Profit; // Суммируем общую прибыль

                if (groupData.ContainsKey(item.Group))
                {
                    var current = groupData[item.Group];
                    groupData[item.Group] = (
                        current.totalPurchase + item.PurchasePrice,
                        current.totalProfit + item.Profit,
                        current.count + 1
                    );
                }
                else
                {
                    groupData[item.Group] = (item.PurchasePrice, item.Profit, 1);
                }
            }

            summaryData = new List<SummaryDataItem>();
            foreach (var item in groupData)
            {
                summaryData.Add(
                    new SummaryDataItem()
                    {
                        GroupName = item.Key,
                        AveragePurchasePrice = item.Value.totalPurchase / item.Value.count,
                        TotalProfit = item.Value.totalProfit
                    });
            }
        }

        private bool InitData(string dataPath)
        {
            rowData = new List<RowDataItem>();
            try
            {
                StreamReader sr = new StreamReader(dataPath, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] items = line.Split(devider);
                    if (items.Length >= 4) // Теперь 4 поля вместо 5
                    {
                        var item = new RowDataItem()
                        {
                            Name = items[0].Trim(),
                            Group = items[1].Trim(),
                            PurchasePrice = Convert.ToSingle(items[2].Trim()),
                            SalePrice = Convert.ToSingle(items[3].Trim())
                        };
                        rowData.Add(item);
                    }
                }
                sr.Close();
                BuildSummary();
            }
            catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        public static DataStorage DataCreator(String path)
        {
            DataStorage dataStorage = new DataStorage();
            if (dataStorage.InitData(path))
            {
                return dataStorage;
            }
            else
            {
                return null;
            }
        }

        public List<RowDataItem> GetRowData()
        {
            if (this.IsReady)
                return rowData;
            else
                return null;
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return summaryData;
            else
                return null;
        }

        public float GetTotalProfit()
        {
            return totalProfit;
        }
    }
}