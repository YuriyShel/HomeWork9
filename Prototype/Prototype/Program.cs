namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prototype();
        }
        static void Prototype()
        {
            var animal1 = new Animal(
                name: "Dog",
                weight: 35, 
                height:100,
                countOfLimbs:4,
                sounds:"Gav-Gav",
                thisGender:Gender.man
                );
            var animal2 = new Bird(new Animal(
                name: "Crow",
                weight: 4,
                height: 15,
                countOfLimbs: 4,
                sounds: "Car-Car",
                thisGender: Gender.women),
                сanFly: true
                );
            var animal3 = new Fish(
              new Animal(
                name: "Tuna",
                weight: 15,
                height: 50,
                countOfLimbs: 8,
                thisGender: Gender.other),
                canBreatheUnderwater:true);
           

            Console.WriteLine($"Животное 1: \n{animal1}\n");
            Console.WriteLine($"Животное 2: \n{animal2}\n");
            Console.WriteLine($"Животное 3: \n{animal3}\n\n");

            var copyAnimal1 = animal1.Copy();
            var copyAnimal2 = animal2.Copy();
            var copyAnimal3 = animal3.Copy();

            var cloneAnimal1 = animal1.Clone();
            var cloneAnimal2 = animal2.Clone();
            var cloneAnimal3 = animal3.Clone();

            Console.WriteLine($"Копия животного 1: \n{copyAnimal1}\n");
            Console.WriteLine($"Клон животного 1: \n{cloneAnimal1}\n");
            Console.WriteLine();
            Console.WriteLine($"Копия животного 2: \n{copyAnimal2}\n");
            Console.WriteLine($"Клон животного 2: \n{cloneAnimal2}\n");
            Console.WriteLine();
            Console.WriteLine($"Копия животного 3: \n{copyAnimal3}\n");
            Console.WriteLine($"Клон животного 3: \n{cloneAnimal3}\n");
            Console.WriteLine();
        }


    }
}