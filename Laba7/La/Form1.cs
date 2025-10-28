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

                // ��������� �������� �� NULL!
                if (data == null)
                {
                    MessageBox.Show("�� ������� ��������� ������ �� �����");
                    return;
                }

                dataGridView.DataSource = data.GetRowData();
                dataGridView.ReadOnly = true;
                dataGridSummary.DataSource = data.GetSummaryData();
                dataGridSummary.ReadOnly = true;

                // ������� ����� ������� � ��������� �����
                this.Text = $"������ ������������ - ����� �������: {data.GetTotalProfit():F2} ���.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("��� �������� ������ ���-�� ���������");
            }
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog.FileName);
            }
        }
    }
}