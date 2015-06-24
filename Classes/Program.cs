using System;

class Animal
{
    // CLASS VARIABLES
    public static int Count = 0;

   public string name ;
   public int age ;
   public float happiness;

    //CLASS CONSTRUCTORS
  public Animal()
   {
       name = "Spotty";
       age = 6;
       happiness = 0.5f;

       Count++;
   }

  public Animal(string _name, int _age, float _happiness)
  {
      name = _name;
      age = _age;
      happiness = _happiness;

      Count++;
  }

    //CLASS METHODS
   public void Print()
   {
       Console.WriteLine("Name: " + name);
       Console.WriteLine("Age: " + age);
       Console.WriteLine("Happiness: " + happiness);
   }

    }

    class Program
    {
       public static void Main(string[] args)
        {
           Animal dog = new Animal();
           dog.Print();

           Console.WriteLine();
           
           Animal cat = new Animal("Mister Beens", 10, 0.5f);
           cat.Print();

           Console.WriteLine();
           Console.WriteLine("Num of animals: " + Animal.Count);


           //Console.WriteLine(dog.name);
           //dog.name = "Test";
           //Console.WriteLine(dog.name);


           Console.ReadKey();           
        }
    }

