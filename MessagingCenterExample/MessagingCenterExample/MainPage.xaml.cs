using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagingCenterExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
            MessagingCenter.Unsubscribe<IntValues>(this, "ReciveData");
            MessagingCenter.Subscribe<IntValues>(this, "ReciveData", (value) =>
            {
                if (value.num1 != 0 && value.num2 != 0)
                {
                    lblMsg.Text = "Sum of";
                    lblMsg.Text += " " + value.num1;
                    lblMsg.Text += " and " + value.num2;
                    lblMsg.Text += " is: " + (value.num1 + value.num2);
                }
                else
                {
                    lblMsg.Text = "Null Exception";
                }
            });
        }
    }
}
