using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GameManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GameManager(IGamerCheckService gamerCheckService )
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Update(Gamer gamer)
        {
         
                base.Update(gamer);
         
            
           
        }
        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not  a valid person");
            }
        }
        public override void Delete(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Delete(gamer);
            }
            else
            {
                throw new Exception("contact deleted");
            }
        }
    }
}
