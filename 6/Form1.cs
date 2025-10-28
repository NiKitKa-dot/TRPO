namespace Laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.Title = "Сохранить результат вычислений";
            saveDialog.InitialDirectory = Application.StartupPath;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveDialog.FileName, txtChooseFont.Text);
                    MessageBox.Show("Результат успешно сохранен!", "Сохранение",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private double CalculateExpression(double x, double y, int n)
        {
            double E = 0;

            for (int i = 1; i <= n; i++)
            {
                double term = 0;
                double denominator = i * (i + 1);

                if (i % 4 == 1) // Первый тип слагаемого: - (sin(y) * x?)/(2·3)
                {
                    term = -Math.Sin(y) * Math.Pow(x, i + 1) / denominator;
                }
                else if (i % 4 == 2) // Второй тип: + sin(x?)/(3·4)
                {
                    term = Math.Sin(Math.Pow(x, i + 1)) / denominator;
                }
                else if (i % 4 == 3) // Третий тип: - (cos(y) * x?)/(4·5)
                {
                    term = -Math.Cos(y) * Math.Pow(x, i + 1) / denominator;
                }
                else if (i % 4 == 0) // Четвертый тип: + sin(x?)/(5·6)
                {
                    term = Math.Sin(Math.Pow(x, i + 1)) / denominator;
                }

                E += term;
            }

            return E;
        }



        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = this.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }

        }
        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            dlg.Font = txtChooseFont.Font;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFont.Font = dlg.Font;
                txtChooseFont.ForeColor = dlg.Color;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        { 
            int x,y,n;
            x = Convert.ToInt32(textBoxX.Text);
            y = Convert.ToInt32(textBoxY.Text);
            n= Convert.ToInt32(textBoxN.Text);
            txtChooseFont.Text = Convert.ToString(CalculateExpression(x,y,n));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
        }
    }
}
