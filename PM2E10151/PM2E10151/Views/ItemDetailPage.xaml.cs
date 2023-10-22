using PM2E10151.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PM2E10151.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}