using Jamie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamie.ViewModel
{


    class RecipeViewModel
    {
        //Variables
        private RecipeSet _Recipes;

        //Constructors
        public RecipeViewModel(RecipeSet Recipes)
        {
            _Recipes = Recipes;
        }

        //Properties
        public RecipeSet Recipes
        {
            get
            {
                return _Recipes;
            }

            set
            {
                _Recipes = value;
            }
        }

        public Recipe SelectedItem
        {
            get
            {
                return _Recipes.SelectedItem;
            }

            set
            {
                _Recipes.SelectedItem = value;
            }
        }



    }
}
