using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xam_ntv
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string message_title_ = "Title";
            string message_body_ = DateTime.Now.ToString();
            string message_button = "تم";

            DisplayAlert(message_title_, message_body_, message_button);
        }
    }
}