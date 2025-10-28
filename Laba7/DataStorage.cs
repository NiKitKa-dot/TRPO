using Laba7_U;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_U
{
    interface DataInterface
    {
        List<RowDataItem> GetRowData();
        List<SummaryDataItem> GetSummaryData();
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

        //Закрытое свойство для хранения списка элементов
        //типа RowDataItem
        private List<RowDataItem> rowData;

        //Закрытое свойство для хранения списка элементов
        //типа SummaryDataItem
        private List<SummaryDataItem> summaryData;

        private char devider = '%';
        private DataStorage() { }

        private void BuildSummary()
        {
            Dictionary<int, float> tmp = new Dictionary<int, float>();
            foreach (var item in rowData)
            {
                if (tmp.ContainsKey(item.Group))
                    tmp[item.Group] += item.Sum;
                else
                    tmp[item.Group] = item.Sum;
            }
            summaryData = new List<SummaryDataItem>();
            foreach (var item in tmp)
            {
                summaryData.Add(
                    new SummaryDataItem()
                    {
                        GroupName = Utils.GetGroupByNumber(item.Key),
                        GroupSum = item.Value
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
                    string[] items = line.Split(devider);
                    var item = new RowDataItem()
                    {
                        Name = items[0].Trim(),
                        Part = items[1].Trim(),
                        Group = Convert.ToInt32(items[2].Trim()),
                        Price = Convert.ToSingle(items[3].Trim()),
                        Count = Convert.ToSingle(items[4].Trim()),
                    };
                    rowData.Add(item);
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
    }
}