using System.Windows;
using System.Windows.Controls;
using LogicTier;

namespace PresentationTier
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new АгентствоНедвижимости();
        }

        private void MainList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Можно добавить дополнительную логику при выборе элемента
        }
    }
}