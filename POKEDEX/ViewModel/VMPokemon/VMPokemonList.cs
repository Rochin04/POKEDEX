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
        //public ObservableCollection<PokemonModel> Lista
        //{
        //    get { return _Lista; }
        //    set { SetValue(ref _Lista, value); OnPropertyChanged(); }
        //}
        #endregion
        #region Procesos
        public async Task Registrar()
        {
            await Navigation.PushModalAsync(new RegistroPokemon());
        }
        public async Task MostrarPokemon()
        {
            var function = new PokemonData();
            ListaPokemon = await function.MostrarPokemon();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region Command
        public ICommand Registrarcommand => new Command(async () => await Registrar());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
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
