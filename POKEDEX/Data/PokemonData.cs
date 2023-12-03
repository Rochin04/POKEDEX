using System;
using System.Collections.Generic;
using System.Text;
using POKEDEX.Model;
using POKEDEX.Connectionn;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace POKEDEX.Data
{
    public class PokemonData
    {

        public async Task InsertarPokemon(PokemonModel parametros)
        {
            await Connection.firebase.Child("Pokemon").PostAsync(new PokemonModel()
            {
                 Name = parametros.Name,
                 BackgronColor = parametros.BackgronColor,
                 Power = parametros.Power,
                 Icon = parametros.Icon,
                 NmOrder = parametros.NmOrder,
                 PowerColor = parametros.PowerColor,
                 IdPokemon = parametros.IdPokemon,
            });
        }
        //public async Task<List<PokemonModel>> MostrarPokemon()
        public async Task<ObservableCollection<PokemonModel>> MostrarPokemon()
        {
            var data = await Task.Run(() => Connection.firebase.Child("Pokemon").AsObservable<PokemonModel>().AsObservableCollection());
            return data;
        }

    }
}

            //return (await Connection.firebase.Child("Pokemon").OnceAsync<PokemonModel>()).Select(item => new PokemonModel
            //{
            //    IdPokemon = item.Key,
            //    Name = item.Object.Name,
            //    BackgronColor = item.Object.BackgronColor,
            //    Power = item.Object.Power,
            //    Icon = item.Object.Icon,
            //    NmOrder = item.Object.NmOrder,
            //    PowerColor = item.Object.PowerColor
            //}).ToList();
        //private INavigation navigation1;
        //private object navigation2;

        //public PokemonData(INavigation navigation1, object navigation2)
        //{
        //    this.navigation1 = navigation1;
        //    this.navigation2 = navigation2;
        //}