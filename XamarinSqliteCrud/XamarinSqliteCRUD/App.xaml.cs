using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqliteCRUD.Model;
using XamarinSqliteCRUD.Validation;
using XamarinSqliteCRUD.View;
using XamarinSqliteCRUD.ViewModel;

namespace XamarinSqliteCRUD
{
    public partial class App : Application
    {
        public App(IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            MainPage = new ValidasyonView();
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
