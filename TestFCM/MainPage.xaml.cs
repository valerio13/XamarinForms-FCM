using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestFCM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SendNotification(object sender, EventArgs e)
        {
            DependencyService.Get<INotification>().CreateNotification("SPTutorials", "hola");
        }
    }
}
