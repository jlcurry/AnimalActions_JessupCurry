/*
	This assignment will take most developers 5-15 minutes.
	Please include all code in one file with your name somewhere in the filename.
	Your returned file should contain more than one class.
*/

/*
	First, create the following four animals.  Do not worry about adding extra detail to each:
	Parrot, Penguin, Pterodactyl, Duck
*/

/*
	Then, populate the static AnimalActions class below with these four methods (and only these four methods).

	Method #1: Eat
	Method #2: Swim
	Method #3: Fly
	Method #4: GetAnimalSound

	These methods may take a parameter or parameters as you find most appropriate.

	Methods #1, #2, and #3 are actions that some animals can do.
	These actions just need to print a description to the console - you do not need to return anything from these methods.
    For example, if I were making the duck sleep, I would do it using this statement: Console.WriteLine("Puts head under wing and closes eyes");
	Please consider the best way to ensure that each animal is only able to take the actions matching their abilities!
	
	The fourth method (GetAnimalSound) should simply return the animal's sound in string form.
	
	Do not provide code executing or testing the class.
*/



using System;

internal static class AnimalActions
{
	public static void Main()
	{
        Parrot parrot = new Parrot();
        Penguin penguin = new Penguin();
        Pterodactyl pterodactyl = new Pterodactyl();
        Duck duck = new Duck();

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", parrot.Eat(), penguin.Swim(), pterodactyl.Fly(), duck.GetAnimalSound());

		Console.ReadKey();

	}

    interface IEat
    {
        string Eat();
    }

    interface ISwim
    {
        string Swim();
    }

    interface IFly
    {
        string Fly();
    }

    interface IGetAnimalSound
    {
        string GetAnimalSound();
    }

    class Parrot : IEat
    {
        public string Eat()
        {
			return "The Parrot stuffs its beak with food";
		}
    }

    class Penguin : ISwim
    {
        public string Swim()
        {
			return "The Penguin glides through the water";
        }
    }

    class Pterodactyl : IFly
    {
        public string Fly()
        {
            return "The Pterodactly soars through the clouds";
        }
    }

    class Duck : IGetAnimalSound
    {
        public string GetAnimalSound()
        {
            return "QUACK";
        }
    }
}

