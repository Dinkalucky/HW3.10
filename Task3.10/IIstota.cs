using System;
using System.Collections.Generic;

namespace Task3._10
{
    public interface IIstota
    {
        string Name { get; set; }
        Types Type { get; set; }
        List<object> gifts { get; set; }
        DateTime LastTime { get; set; }
        void TakeGift(MagicBox<IIstota> magicBox);
        void ShowGifts();
    }
}