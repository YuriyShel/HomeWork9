using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype
{
    public enum Gender {man, women, other}
    /// <summary>
    /// Класс животные
    /// </summary>
    public class Animal: ICloneable, IMyCloneable<Animal>
    {
        //Название
        public string Name { get; set; }
        //Вес
        public uint Weight { get; set; }
        //Рост
        public uint Height { get; set; }
        //Пол
        public Gender ThisGender { get; set; }
        //Количество конечностей
        public uint CountOfLimbs { get; set; }
        //Издаваемые звуки
        public string? Sounds { get; set; }
        public Animal() { }
        public Animal(string name, uint weight, uint height,                      
                      uint countOfLimbs, string? sounds = default, 
                      Gender thisGender = Gender.other)
        {
            Name = name;
            Weight = weight;
            Height = height;
            ThisGender = thisGender;
            CountOfLimbs = countOfLimbs;
            Sounds = sounds;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        /// <summary>
        /// Реализация ICloneable
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return Copy();
        }

        /// <summary>
        /// Реализация IMyCloneable<Animal> - паттерн прототип
        /// </summary>
        /// <returns></returns>
        public virtual Animal Copy()
        {
            return new Animal(Name, Weight, Height, CountOfLimbs, Sounds, ThisGender);
        }
    }
}
