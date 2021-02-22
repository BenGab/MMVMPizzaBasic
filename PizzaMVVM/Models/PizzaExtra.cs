using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMVVM.Models
{
    public class PizzaExtra : ObservableObject
    {
        private string name;
        private decimal price;
        private bool isWanted;

        public string ExtraName { get => name; set => Set(ref name, value); }

        public decimal Price { get => price; set => Set(ref price, value); }

        public bool IsWanted { get => isWanted; set => Set(ref isWanted, value); }
    }
}
