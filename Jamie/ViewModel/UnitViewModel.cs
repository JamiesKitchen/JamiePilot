using Jamie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamie.ViewModel
{
    class UnitViewModel
    {
        //Variables
        private UnitSet _Units;

        //Constructors
        public UnitViewModel(UnitSet Units)
        {
            _Units = Units;
        }

        //Properties
        public UnitSet Units
        {
            get
            {
                return _Units;
            }

            set
            {
                _Units = value;
            }
        }
        public Unit SelectedItem
        {
            get
            {
                return _Units.SelectedItem;
            }

            set
            {
                _Units.SelectedItem = value;
            }
        }


    }
}
