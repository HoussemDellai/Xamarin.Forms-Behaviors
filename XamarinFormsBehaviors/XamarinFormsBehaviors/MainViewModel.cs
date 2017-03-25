using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsBehaviors
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _selectedProduct;
        private string _purchasedProducts = "You purchased: ";

        public List<string> Products => new List<string>
        {
            "Computer", "Smartphone", "Tablet", "Keyboard", "Mouse", "Screen", "Headset"
        };

        public string SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }

        public string PurchasedProducts
        {
            get { return _purchasedProducts; }
            set
            {
                _purchasedProducts = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectCommand => new Command(() =>
        {
            PurchasedProducts += SelectedProduct + ", ";
        });

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
