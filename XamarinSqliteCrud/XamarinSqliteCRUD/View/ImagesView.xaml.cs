using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSqliteCRUD.View.CustomControl;

namespace XamarinSqliteCRUD.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagesView : ContentPage
    {
        Image _img;
        public ImagesView()
        {
            InitializeComponent();
            RelativeLayout layout = new RelativeLayout();
            CustomButton btnPickPhoto = new CustomButton
            {
                Text = "Pick Photo"
            };
            btnPickPhoto.Clicked += BtnPickPhoto_Clicked;
            StackLayout stkImage = new StackLayout
            {
                BackgroundColor = Color.White
            };
            _img = new Image
            {
                Source = "defaultimg.png"
            };
            stkImage.Children.Add(_img);
            layout.Children.Add(stkImage, Constraint.Constant(0),
                Constraint.Constant(0), Constraint.RelativeToParent(
                    (parent) =>
                    {
                        return parent.Width;
                    }));
            StackLayout stkPictureButtons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = 20,
                Children =
                {
                    btnPickPhoto,
                }
            };
            layout.Children.Add(stkPictureButtons, Constraint.Constant(0),
                Constraint.Constant(0), Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }));
            Content = layout;
        }
        private async void BtnPickPhoto_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                DisplayAlert("UYARI", "Galeriye erişme yetkiniz yok!", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            _img.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
    }
}