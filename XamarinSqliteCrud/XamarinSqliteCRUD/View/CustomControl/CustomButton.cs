using Xamarin.Forms;

namespace XamarinSqliteCRUD.View.CustomControl
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            this.TextColor = Color.Red;
            this.BackgroundColor = Color.Transparent;
            this.BorderColor = Color.Red;
            this.HorizontalOptions = new LayoutOptions(
                LayoutAlignment.Fill, true);
            this.BorderWidth = 2;
            this.BorderRadius = 1;
        }
    }
}
