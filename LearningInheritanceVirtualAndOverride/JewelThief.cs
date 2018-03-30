using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritanceVirtualAndOverride
{
    class JewelThief: Locksmith
    {
        private Jewels stolenJewels = null;
        public void  ReturnContetns(Jewels safeContents, Owner owner)
        
        {
                stolenJewels = safeContents;
                Console.WriteLine("Kradnę zawartość sejfu! " + stolenJewels.Sparkle());
            
        }
    }
}
