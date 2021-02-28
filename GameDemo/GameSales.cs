using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    internal class GameSales : Gamer 
        { 
        public void Sale(Games games, Gamer gamer)
        {
            Console.WriteLine(games.Name + " purchased by " + gamer.FirstName);
        }

      
    }
}
