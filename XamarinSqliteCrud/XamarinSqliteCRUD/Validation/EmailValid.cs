using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinSqliteCRUD.Validation
{
    public class EmailValid : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }
        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;
            var emailEntry = sender as Entry;
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if (validEmailPattern.Contains(validEmailPattern))
            {
                emailEntry.BackgroundColor = Color.Red;
            }
            else
            {
                emailEntry.BackgroundColor = Color.Wheat;
            }
        }
    }
    public class TCKNValid : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }
        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            var email = e.NewTextValue;
            var emailEntry = sender as Entry;
            if (email.Length == 11)
            {
                emailEntry.BackgroundColor = Color.Red;
            }
            else
            {
                emailEntry.BackgroundColor = Color.Wheat;
            }
        }
    }
}
