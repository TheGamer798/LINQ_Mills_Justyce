using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Mills_Justyce
{
    internal class Game
    {
        public string Title { get; }//string called Title type with automatic getter

        public char Esrb { get; }//char type called Esrb with automatic getter

        public string Genre { get; }//string type called Genre with automatic getter

        public Game(string titleParam, char esrbParam, string genreParam)//a constructor that passes 3 parameters
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }
    }
}
