using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
     abstract class BaseGamerManager:IGamerService
    {

        public virtual void Delete(Gamer gamer) 
        { 
            Console.WriteLine("Deleted Gamer " + gamer.FirstName + " " + gamer.LastName); 
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Saved Gamer " + gamer.FirstName + " " + gamer.LastName);
        }

        public virtual void Update(Gamer gamer)
        {   
            Console.WriteLine("Updated Gamer " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
