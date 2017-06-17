using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListViewW3.Model;
using System.Collections;
using System.Collections.ObjectModel;

namespace ListViewW3.ViewModel
{
    class ListPageViewModel
    {
        //public List<ElementsModel> Elementos = new List<ElementsModel>();

        public ObservableCollection<ElementsModel> Elementos { get; set; } = new ObservableCollection<ElementsModel>();

        ElementsModel _itemSelected;
        public ElementsModel ItemSelected
        {
            get
            {
                return _itemSelected;
            }
            set
            {
                _itemSelected = value;

                if (_itemSelected != null)
                {
                    App.Current.MainPage.DisplayAlert("Element Detail", $"{value.Person} is {value.Element}", "OK");
                }
            }
        }

        public ListPageViewModel()
        {
            Elementos.Add(new ElementsModel() { Image = "wind.png", Element = "Wind", Person = "Aang" });
            Elementos.Add(new ElementsModel() { Image = "water.png", Element = "Water", Person = "Katara" });
            Elementos.Add(new ElementsModel() { Image = "fire.png", Element = "Fire", Person = "Zuko" });
            Elementos.Add(new ElementsModel() { Image = "earth.png", Element = "Earth", Person = "Toph" });
        }



    }
    
}
