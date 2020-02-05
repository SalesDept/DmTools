using System;
using System.Collections.Generic;
using System.Text;

namespace DmTools
{
    class DiceBag
    {
        public enum Dice : int
        {            
            d2 = 2,            
            d4 = 4,            
            d6 = 6,            
            d8 = 8,            
            d10 = 10,           
            d12 = 12,            
            d20 = 20,
            d100 = 100
        };

        private Random _rng;

        public DiceBag()
        {
            _rng = new Random();
        }

        /**
         * The default dice-rolling method. All methods link to this one.
         */
        private int InternalRoll(int dice)
        {
            return 1 + _rng.Next((int)dice);
        }

       
        public int Roll(Dice d)
        {
            return InternalRoll((int)d);
        }

        
        public int RollWithModifier(Dice dice, int modifier)
        {
            return InternalRoll((int)dice) + (int)modifier;
        }

        
        public List<int> RollQuantity(Dice d, int times)
        {
            List<int> rolls = new List<int>();
            for (int i = 0; i < times; i++)
            {
                rolls.Add(InternalRoll((int)d));
            }
            return rolls;
        }
    }
}
    

