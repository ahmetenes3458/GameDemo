using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGamerService
    {
       
         void Save(Gamer gamer);
     
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
