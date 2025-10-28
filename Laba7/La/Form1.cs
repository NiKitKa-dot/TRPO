using Laba7_zag;
using System;
using System.Windows.Forms;

namespace Laba7_zag
{
    public partial class Form1 : Form
    {
        DataStorage data;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowData(string dataPath)
        {
            try
            {
                data = DataStorage.DataCreator(dataPath);

                // ДОБАВЛЯЕМ ПРОВЕРКУ НА NULL!
                if (data == null)
                {
                    MessageBox.Show("Не удалось загрузить данные из файла");
                    return;
                }

                dataGridView.DataSource = data.GetRowData();
                dataGridView.ReadOnly = true;
                dataGridSummary.DataSource = data.GetSummaryData();
                dataGridSummary.ReadOnly = true;

                // Выводим общую прибыль в заголовок формы
                this.Text = $"Анализ прибыльности - Общая прибыль: {data.GetTotalProfit():F2} руб.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("При загрузке данных что-то сломалось");
            }
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog.FileName);
            }
        }
    }
}