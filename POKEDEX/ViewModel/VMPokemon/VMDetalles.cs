using POKEDEX.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace POKEDEX.ViewModel.VMPokemon
{
    public class VMDetalles:BaseViewModel
    {
        string _Texto;
        public PokemonModel ParametrosRecibe { get; set; } 
        #region CONSTRUCTOR
        public VMDetalles(INavigation navigation, PokemonModel ParametrosTrae)
        {
            Navigation = navigation;
            ParametrosRecibe = ParametrosTrae;
        }
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public async Task Volver()
        {
            await Navigation.PopModalAsync();
        }
        public void ProcesoSimple()
        {
        }
        #endregion
        #endregion
        #region COMANDO
        public ICommand ProcesoAsyncronocommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimCommand => new Command(ProcesoSimple);
        #endregion
    }
}
