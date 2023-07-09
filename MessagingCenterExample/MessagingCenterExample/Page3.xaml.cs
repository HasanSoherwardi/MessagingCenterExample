using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagingCenterExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
        public int fValue = 0;
		public Page3 (int num1)
		{
            fValue = num1;
			InitializeComponent ();
            lblFNum.Text = "Your First Number is: " + fValue;
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            IntValues val = new IntValues();
            val.num1 = fValue;
            val.num2 = Convert.ToInt32(txtNum2.Text);

            MessagingCenter.Send<IntValues>(val, "ReciveData");
            // This Code for jump to Page 1
            await Navigation.PopToRootAsync();
        }
    }
}