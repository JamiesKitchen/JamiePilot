using Jamie.View;
using Jamie.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jamie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AllDataSetViewModel _ViewModel;
        private RecipeViewModel _RecipeVM;

        public MainWindow()
        {
            InitializeComponent();
            _ViewModel = new AllDataSetViewModel();
            _RecipeVM = new RecipeViewModel(_ViewModel.Recipes);
            this.DataContext = _RecipeVM;
            
        }
    }
}
