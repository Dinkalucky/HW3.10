using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._10
{
    public class Istota : IIstota
    {
        public string Name { get; set; }
        public Types Type { get; set; }
        public List<object> gifts { get; set; }
        public DateTime LastTime { get; set; }

        public Istota(Types type, string name)
        {
            Type = type;
            Name = name;
            gifts = new List<object>();
        }
        public void TakeGift(MagicBox<IIstota> magicBox)
        {
            var gift = magicBox.GiveGift(this);
            if (gift != null)
            {
                gifts.Add(gift);
                LastTime = DateTime.Now;
            }
        }

        public void ShowGifts()
        {
            foreach (var gift in gifts)
            {
                Console.WriteLine(gift);
            }
        }
    }
}
