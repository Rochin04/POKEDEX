using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace POKEDEX.Connectionn
{
    public class Connection
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvm-2c13a-default-rtdb.firebaseio.com/");
    }
}
