using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POKEDEX.ViewModel.VMPokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using POKEDEX.Views;

namespace POKEDEX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarPokemon : ContentPage
    {
        public ListarPokemon()
        {
            InitializeComponent();
            BindingContext = new VMPokemonList(Navigation);

        }
    }
}