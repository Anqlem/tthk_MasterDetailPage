using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tthk_MasterDetailPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Shikamaru : ContentPage
    {
        public Shikamaru()
        {
            InitializeComponent();
        }

        private async void bpBut_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://naruto.fandom.com/wiki/Shikamaru_Nara");
            await Browser.OpenAsync(uri);
        }
    }
}