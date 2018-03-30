using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritanceVirtualAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner); //even if JewelThief got his own method ReturnContetns() the base one will be used, because we only hide base method not override it. 
                                              //If we wanna use new method w/o overriding we have to use JewelThief.ReturnContetns()
            Console.ReadKey();
        }
    }
}
