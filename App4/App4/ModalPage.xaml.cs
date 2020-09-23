using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        String A { get; set; }
        String B { get; set; }
        String C { get; set; }
        String D { get; set; }


        public ModalPage(String a, String b, String c, String d)
        {
            InitializeComponent();
            A = a;
            B = b;
            C = c;
            D = d;
            this.aText.Text = A;
            this.bText.Text = B;
            this.cText.Text = C;
            this.dText.Text = D;
        }



        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}