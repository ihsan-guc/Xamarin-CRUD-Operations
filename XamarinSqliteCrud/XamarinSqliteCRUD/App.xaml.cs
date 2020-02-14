using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.View;
using XamarinSqliteCRUD.ViewModel;

namespace XamarinSqliteCRUD
{
    public partial class App : Application
    {
        public App(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            MainPage = new ImagesView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
