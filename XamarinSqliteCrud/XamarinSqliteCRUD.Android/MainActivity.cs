using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using SqliteOrnek2.DAL;
using SqliteOrnek2.DAL.Repository;
using System.IO;
using XamarinSqliteCRUD.Model;

namespace XamarinSqliteCRUD.Droid
{
    [Activity(Label = "XamarinSqliteCRUD", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            var dbPath = Path.Combine(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal), "Personel.db");
            LoginRepository loginRepository = new LoginRepository();
            DepartmentRepository departmentRepository = new DepartmentRepository(dbPath);
            PersonelRepository personelRepository = new PersonelRepository(dbPath);
            var productRepository = new UnitOfWork(loginRepository,departmentRepository, dbPath,personelRepository);
            LoadApplication(new App(productRepository));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}