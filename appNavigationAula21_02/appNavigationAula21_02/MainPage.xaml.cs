using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appNavigationAula21_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAlunos_Clicked(object sender, EventArgs e)
        {

        }

        private void btnProfessores_Clicked(object sender, EventArgs e)
        {

        }

        async void btnCursos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cursos());
        }

        private void btnDisciplinas_Clicked(object sender, EventArgs e)
        {

        }
    }
}
