using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appNavigationAula21_02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cursos : ContentPage
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnGravar_Clicked(object sender, EventArgs e)
        {

        }

        async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}