using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment1
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManagerPanelPage : ContentPage
    {
        public ManagerPanelPage()
        {
            InitializeComponent();
        }

        async void historyOrRestock(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if(b.Text.Equals("History")) await Navigation.PushAsync(new PurchaseHistoryPage());
            else await Navigation.PushAsync(new RestockPage());
        }
    }
}