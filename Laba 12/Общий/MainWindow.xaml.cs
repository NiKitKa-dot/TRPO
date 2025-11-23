using LogicTier;
using System.Windows;

namespace PresentationTier
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Магазин logicTier = new Магазин();
            this.DataContext = logicTier;
            InitializeComponent();
        }
    }
}