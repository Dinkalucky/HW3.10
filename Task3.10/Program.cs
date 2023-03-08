using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._10
{
    public interface IMagicBox
    {
        string TypeOfHero
        {
            get;
            set;
        }
    }

    public class MagicBox<IMagicBox>
    {
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
