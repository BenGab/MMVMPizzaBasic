using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PizzaMVVM.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace PizzaMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Pizza selectedPizza; 
        public ObservableCollection<Pizza> Pizzas { get; set; }

        public Pizza SelectedPizza { get=> selectedPizza; set => Set(ref selectedPizza, value); }

        public RelayCommand AddNewPizzaCommand
        {
            get
            {
                return new RelayCommand(AddNewPizza);
            }
        }

        public RelayCommand DeletePizzaCommand
        {
            get
            {
                return new RelayCommand(DeletePizza);
            }
        }

        public MainViewModel()
        {
            Pizzas = new ObservableCollection<Pizza>();
            FillPizzas();
            selectedPizza = Pizzas.First();
        }


        private void FillPizzas()
        {
            Pizza pizza1 = new Pizza();
            pizza1.Name = "Margerita";

            FillDefaultExtras(pizza1);

            Pizzas.Add(pizza1);
        }

        private void FillDefaultExtras(Pizza instance)
        {
            instance.Extras.Add(new PizzaExtra()
            {
                ExtraName = "Extra Cheese",
                Price = 200,
                IsWanted = false
            });

            instance.Extras.Add(new PizzaExtra()
            {
                ExtraName = "Extra Meat",
                Price = 2300,
                IsWanted = false
            });
        }

        private void AddNewPizza()
        {
            Pizza newpizza = new Pizza();
            newpizza.Name = "NewPizza";
            FillDefaultExtras(newpizza);
            Pizzas.Add(newpizza);
        }

        private void DeletePizza()
        {
            if(selectedPizza == null)
            {
                return;
            }

            Pizzas.Remove(selectedPizza);
            SelectedPizza = Pizzas.First();
        }
    }
}
