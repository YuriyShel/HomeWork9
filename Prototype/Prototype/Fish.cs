using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// Класс рыбы
    /// </summary>
    public class Fish : Animal, ICloneable
    {       
        public bool CanBreatheUnderwater { get; set; } = true;

        public Fish() : base() { }

        public Fish(Animal animal, bool canBreatheUnderwater):
            base(animal.Name, animal.Weight, animal.Height, animal.CountOfLimbs, animal.Sounds, animal.ThisGender)
        {
            CanBreatheUnderwater = canBreatheUnderwater;
        }

        public override Animal Copy()
        {       
            return new Fish(new Animal(Name, Weight, Height, CountOfLimbs, Sounds, ThisGender), CanBreatheUnderwater);
        }

        /// <summary>
        /// Реализация ICloneable
        /// </summary>
        /// <returns></returns>
        new public object Clone()
        {
            return Copy();
        }
    }
}
