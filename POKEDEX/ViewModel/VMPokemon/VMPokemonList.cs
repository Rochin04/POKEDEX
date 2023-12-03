using POKEDEX.Data;
using POKEDEX.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using POKEDEX.Model;

namespace POKEDEX.ViewModel.VMPokemon
{
    public class VMPokemonList:BaseViewModel
    {
        #region Variables
        string _Text;
        ObservableCollection<PokemonModel> _ListaPokemon;
        //ObservableCollection<PokemonModel> _Lista;
        #endregion
        #region Objeto
        public ObservableCollection<PokemonModel> ListaPokemon
        {
            get { return _ListaPokemon; }
            set { SetValue(ref _ListaPokemon, value);
                OnPropertyChanged();
            }
        }
        #endregion
        #region Procesos
        public async Task Registrar()
        {
            await Navigation.PushModalAsync(new RegistroPokemon());
        }
        public async Task DetallesPokemon(PokemonModel parametros)
        {
            await Navigation.PushModalAsync(new DetallesPokemon(parametros));
        }
        public async Task Editar()
        {
            // Aquí puedes agregar lógica para preparar datos antes de navegar a la página de edición
            // Por ejemplo, puedes pasar el ID del Pokémon que se va a editar

            // Supongamos que tienes una propiedad en tu ViewModel llamada PokemonSeleccionado
            //string pokemonId = PokemonSeleccionado?.Id;

            //if (!string.IsNullOrEmpty(pokemonId))
            //{
            //    // Navegar a la página de edición, pasando el ID del Pokémon
            //    await Navigation.PushAsync(new EditarPokemon(pokemonId));
            //}
        }
        public async Task MostrarPokemon()
        {
            var function = new PokemonData();
            ListaPokemon = await function.MostrarPokemon();
        }
        #endregion
        #region Command
        public ICommand Registrarcommand => new Command(async () => await Registrar());
        public ICommand Detallescommand => new Command<PokemonModel>(async (p) => await DetallesPokemon(p));
        public ICommand EditarCommand => new Command(async () => await Editar());
        #endregion
        #region Constructor
        public VMPokemonList(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPokemon();
        }
        #endregion
    }
}
