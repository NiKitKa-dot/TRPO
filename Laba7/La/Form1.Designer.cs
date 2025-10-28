namespace Laba7_zag
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null; // Контейнер для компонентов

        protected override void Dispose(bool disposing) // Метод освобождения ресурсов
        {
            if (disposing && (components != null))
            {
                components.Dispose();              // Освобождаем компоненты
            }
            base.Dispose(disposing);               // Вызываем базовый метод
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()         // Автоматически сгенерированный код инициализации UI
        {
            this.dataGridView = new System.Windows.Forms.DataGridView(); // Создаем таблицу для сырых данных
            this.dataGridSummary = new System.Windows.Forms.DataGridView(); // Создаем таблицу для сводных данных
            this.LoadData = new System.Windows.Forms.Button(); // Создаем кнопку загрузки
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog(); // Создаем диалог открытия файла

            // Настройка dataGridView (таблица детальных данных)
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(464, 362);
            this.dataGridView.TabIndex = 0;

            // Настройка dataGridSummary (таблица сводных данных)
            this.dataGridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSummary.Location = new System.Drawing.Point(499, 13);
            this.dataGridSummary.Name = "dataGridSummary";
            this.dataGridSummary.RowHeadersWidth = 51;
            this.dataGridSummary.Size = new System.Drawing.Size(289, 361);
            this.dataGridSummary.TabIndex = 1;

            // Настройка кнопки LoadData
            this.LoadData.Location = new System.Drawing.Point(12, 395);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(202, 43);
            this.LoadData.Text = "Загрузить данные";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click); // Привязываем обработчик

            // Настройка формы
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.dataGridSummary);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Загрузка данных";
        }

        #endregion

        // Объявление компонентов формы
        private System.Windows.Forms.DataGridView dataGridView;       // Таблица детальных данных
        private System.Windows.Forms.DataGridView dataGridSummary;    // Таблица сводных данных  
        private System.Windows.Forms.Button LoadData;                 // Кнопка загрузки
        private System.Windows.Forms.OpenFileDialog openFileDialog;   // Диалог выбора файла
    }
}