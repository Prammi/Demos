using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    class FlyWeightFactory
    {
        IPlayer _player;

      static  Dictionary<string, IPlayer> flyweight = new Dictionary<string, IPlayer>();

        public static IPlayer GetPlayer(string type)
        {
            IPlayer player = null;

            if (flyweight.ContainsKey(type))
            {
                return flyweight[type];
            }
            else
            {
                if (type == "terrorist")
                {
                    player = new Terrorist();
                }
                if (type == "antiterrorist")
                {
                    player = new AntiTerrorist();
                }
                flyweight.Add(type, player);
                return player;
            }
        }
    }
}
