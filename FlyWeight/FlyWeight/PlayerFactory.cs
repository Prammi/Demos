using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class PlayerFactory
    {
        private static Dictionary<String, IPlayer> hm =
                        new Dictionary<String, IPlayer>();

        public static IPlayer getPlayer(String type)
        {
            IPlayer p = null;

            if (hm.ContainsKey(type))
            {
                return hm[type];

            }
            else
            {
                switch (type)
                {
                    case "Terrorist":
                        p = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        p = new CounterTerrorist();
                        break;

                }
                hm.Add(type, p);
            }
            return p;
        }
    }
}
