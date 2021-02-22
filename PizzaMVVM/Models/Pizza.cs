using GalaSoft.MvvmLight;
using System.ComponentModel;
using System.Linq;

namespace PizzaMVVM.Models
{
    public class Pizza : ObservableObject
    {
        private string name;
        public BindingList<PizzaExtra> Extras { get; private set; }

        public string Name { get=>name; set => Set(ref name, value); }

        public decimal TotalPrice
        {
            get
            {
                return Extras.Where(x => x.IsWanted).Sum(x => x.Price);
            }
        }

        public Pizza()
        {
            Extras = new BindingList<PizzaExtra>();
            Extras.ListChanged += (s, e) =>
            {
                RaisePropertyChanged(() => TotalPrice);
            };
        }

    }
}
