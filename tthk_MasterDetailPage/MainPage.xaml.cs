using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tthk_MasterDetailPage
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("banner.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(View.Page1);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Boruto Uzumaki",
                Detail = "Naruto's Son",
                ImagePath = "boruto.png",
                TargetPage = typeof(View.Boruto)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Naruto Uzumaki",
                Detail = "7th Hokage",
                ImagePath = "naruto.png",
                TargetPage = typeof(View.Naruto)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Kakashi Hatake",
                Detail = "6th Hokage",
                ImagePath = "kakashi.png",
                TargetPage = typeof(View.Kakashi)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Sakura Haruno",
                Detail = "Sarada's mother",
                ImagePath = "sakura.png",
                TargetPage = typeof(View.Sakura)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mitsuki",
                Detail = "Member of team 7",
                ImagePath = "mitsuki.png",
                TargetPage = typeof(View.Mitsuki)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Sasuke Uchiha",
                Detail = "Sarada's Father",
                ImagePath = "sasuke.png",
                TargetPage = typeof(View.Sasuke)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Sarada Uchiha",
                Detail = "Member of team 7",
                ImagePath = "sarada.png",
                TargetPage = typeof(View.Sarada)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Shikamaru Nara",
                Detail = "Hokage's Assistant",
                ImagePath = "shikamaru.png",
                TargetPage = typeof(View.Shikamaru)
            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
