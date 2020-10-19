using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rebane : TabbedPage
    {
        public Rebane()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Посмотрите какая красивая фотография!";
        }
    }
}