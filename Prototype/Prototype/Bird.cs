using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// Класс птицы
    /// </summary>
    public class Bird : Animal, ICloneable
    {
        public bool CanFly{ get; set; } = true;
      
        public Bird(Animal animal, bool сanFly):
            base(animal.Name,animal.Weight, animal.Height, animal.CountOfLimbs, animal.Sounds, animal.ThisGender)
        {            
            CanFly = сanFly;
        }

        public override Animal Copy()
        {
            return new Bird(new Animal(Name, Weight, Height, CountOfLimbs, Sounds, ThisGender), CanFly);
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
