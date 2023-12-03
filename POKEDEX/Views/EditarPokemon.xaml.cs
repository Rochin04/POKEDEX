using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POKEDEX.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditarPokemon : ContentPage
	{
		public EditarPokemon (string pokemonId)
		{
			InitializeComponent ();
		}
	}
}