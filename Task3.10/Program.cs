using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._10
{
    public enum Types
    {
        AnyPerson,
        Driver,
        Gamer,
        Reader
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MagicBox<IIstota> magicBox = new MagicBox<IIstota>();
            IIstota Dina = new Istota(Types.Reader, "Dina");
            IIstota Alex = new Istota(Types.Gamer, "Alex");
            IIstota Ira = new Istota(Types.Driver, "Ira");

            Dina.TakeGift(magicBox);
            Dina.TakeGift(magicBox);
            Alex.TakeGift(magicBox);
            Alex.TakeGift(magicBox);
            Ira.TakeGift(magicBox);
            Ira.TakeGift(magicBox);

            Dina.ShowGifts();
            Ira.ShowGifts();
            Alex.ShowGifts();
            Console.ReadKey();
        }
    }
}
