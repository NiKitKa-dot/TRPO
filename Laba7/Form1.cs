using Laba7_U;
using System;
using System.Windows.Forms;

namespace Laba7_U
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ѕри загрузке данных что-то сломалось");
            }
            dataGridView.DataSource = data.GetRowData();
            dataGridView.ReadOnly = true;
            dataGridSummary.DataSource = data.GetSummaryData();
            dataGridSummary.ReadOnly = true;
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog.FileName);
            }
        }
    }
}