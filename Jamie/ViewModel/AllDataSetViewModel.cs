using Jamie.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamie.ViewModel
{   


    class AllDataSetViewModel
    {
        //Variables
        private AllDataSets _AllSetData;
        private static string filename = "DATA\\ObservedUnits.rds";

        //Constructors
        public AllDataSetViewModel()
        {
            AllSetData = new AllDataSets();
            OpenLists();
        }

        //Properties
        public AllDataSets AllSetData
        {
            get
            {
                return _AllSetData;
            }

            set
            {
                _AllSetData = value;
            }
        }

        public RecipeSet Recipes
        {
            get
            {
                return _AllSetData.Recipes;
            }
            set
            {
                _AllSetData.Recipes = value;
            }

        }
        public UnitSet Units
        {
            get
            {
                return _AllSetData.Units;
            }
            set
            {
                _AllSetData.Units = value;
            }
        }

        public Unit SelectedUnit
        {
            get
            {
                return _AllSetData.Units.SelectedItem;
            }
            set
            {
                _AllSetData.Units.SelectedItem = value; 
            }

        }


        //Methods
        public void ClearLists()
        {
            AllSetData.ClearList();
        }
        public void OpenLists()
        {
            using (Stream fs = new FileStream(filename, FileMode.Open))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(AllSetData.GetType());
                AllSetData = (AllDataSets)x.Deserialize(fs);
            }
            AllSetData.EvaluateMaxIDs();
            AllSetData.SetDataReference();
        }
        public void SaveLists()
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(AllSetData.GetType());
                x.Serialize(fs, AllSetData);
            }

        }


    }
}
