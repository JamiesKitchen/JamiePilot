/* JamiePilot: Pilotprogramm zur Vorarbeit im Projekt "Jamie". Zweite Version ist aus der Kommandozeilen-Anwendung 
 * hervorgegangen. Das Model ist aus dieser übernommen und wird mit dem WPF-User-Interface ergänzt.
 * Autor: Klaus Christochowitz  10-2016
 
 * Version 0.01 - 2016-10-09: Ersanlage des Projektes
 */

/* Version 0.01 - 2016-10-09: Ersanlage des Projektes
 * 
 * Version 0.02 - 2016-10-0x: x
 *                            - 
 *                            

 *                            - offen: 
 *                              --> UnitTranslation Anzeigemodus (valid, invalid)
 *                              --> UnitTranslation Prozedur, um Einträge zu validieren (invalid -> valid)
 *                              --> setzen der ID prüfen ...if ID!=null .... für alle Klassen mit ID (Unit, UnitTranslation....)
 *                              --> anpassen EqualKey für diverse Klassen
 *                              --> in Listenklassen hinzu: GetItem (Key)
 *                              
 *                              
 *                              
 *                              --> UnitTranslationSet.AddItem(UnitTranslation ItemToBeAdded): Reduzierung der Fälle
 *                              --> ShoppingList hinzu
 *                              --> Berechnung der Bedarfe in der Shopping List
 *                              
 *                             
 * 
 * Offene Fragen: - 
 * 
 */


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
        private UnitViewModel _UnitsVM;

        internal AllDataSetViewModel ViewModel
        {
            get
            {
                return _ViewModel;
            }

            set
            {
                _ViewModel = value;
            }
        }
        internal RecipeViewModel RecipeVM
        {
            get
            {
                return _RecipeVM;
            }

            set
            {
                _RecipeVM = value;
            }
        }
        internal UnitViewModel UnitsVM
        {
            get
            {
                return _UnitsVM;
            }

            set
            {
                _UnitsVM = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new AllDataSetViewModel();
            RecipeVM = new RecipeViewModel(ViewModel.Recipes);
            UnitsVM = new UnitViewModel(ViewModel.Units);
            this.DataContext = UnitsVM;
            
        }
    }
}
