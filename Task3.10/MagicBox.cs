using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._10
{
    public class MagicBox<T> where T: IIstota
    {
        private static MagicBox<T> magicBox = null;
        public MagicBox(){}

        public MagicBox<T> Box()
        {
            if (magicBox == null)
            {
                magicBox = new MagicBox<T>();
            }

            return magicBox;
        }

        public object GiveGift(Istota istota)
        {
            var now = DateTime.Now;
            if (now - istota.LastTime > TimeSpan.FromDays(1))
            {
                if (istota.Type == Types.AnyPerson)
                {
                    return "Money";
                }
                else if (istota.Type == Types.Driver)
                {
                    return "Car";
                }
                else if (istota.Type == Types.Gamer)
                {
                    return "Game";
                }
                else if (istota.Type == Types.Reader)
                {
                    return "Book";
                }
                else
                {
                    Console.WriteLine($"{istota.Name}, this type is unknown. Choose another please...");
                    return null;
                }
                    
                }
            else
            {
                Console.WriteLine($"{istota.Name}, 24 hours hadn't passed yet. Try again later...");
                return null;
            }
        }
    }
}
