// Here we declare an interface named ISoundBehaviour with a single method MakeSound
public interface ISoundBehaviour
{
    void MakeSound();
}

// Here we declare an abstract class Animal, which will be the base class for all animals
public abstract class Animal
{
    // We declare some properties with getters and setters
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    // This is the constructor for the Animal class, which will be used by derived classes
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    // This is a virtual method, meaning it can be overridden by derived classes
    public virtual void Eat()
    {
        Console.WriteLine($"{Name} the {Species} is eating.");
    }
}

// The Lion class is derived from the Animal base class and implements the ISoundBehaviour interface
public class Lion : Animal, ISoundBehaviour
{
    // This is the constructor for the Lion class, which calls the base class constructor and adds the Lion to a Habitat
    public Lion(string name, int age, Habitat habitat) : base(name, age, "Lion")
    {
        habitat.AddAnimal(this);
    }

    // Here we override the virtual Eat method from the Animal class
    public override void Eat()
    {
        Console.WriteLine($"{Name} the Lion is eating meat.");
    }

    // Here we provide an implementation for the MakeSound method from the ISoundBehaviour interface
    public void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion is roaring!");
    }
}

// The Elephant class is similar to the Lion class, but with different implementations for the Eat and MakeSound methods
public class Elephant : Animal, ISoundBehaviour
{
    public Elephant(string name, int age, Habitat habitat) : base(name, age, "Elephant")
    {
        habitat.AddAnimal(this);
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Elephant is eating peanuts.");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} the Elephant is trumpeting!");
    }
}

// The Monkey class is also similar to the Lion and Elephant classes
public class Monkey : Animal, ISoundBehaviour
{
    public Monkey(string name, int age, Habitat habitat) : base(name, age, "Monkey")
    {
        habitat.AddAnimal(this);
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Monkey is eating bananas.");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} the Monkey is chattering!");
    }
}

// The Fish class is derived from the Animal class, but does not implement the ISoundBehaviour interface
public class Fish : Animal
{
    public Fish(string name, int age, Habitat habitat) : base(name, age, "Fish")
    {
        habitat.AddAnimal(this);
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Fish is eating seaweed.");
    }
}

// The Habitat class represents a place where animals live
public class Habitat
{
    public string Name { get; set; }
    private List<Animal> Animals { get; set; }

    public Habitat(string name)
    {
        Name = name;
        Animals = new List<Animal>();
    }

    // The AddAnimal method is used to add an animal to the habitat
    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    // The GetAnimals method is used to get a list of all animals in the habitat
    public List<Animal> GetAnimals()
    {
        return Animals;
    }
}

// The Zoo class represents a zoo, which contains several habitats
public class Zoo
{
    private List<Habitat> Habitats { get; set; }

    public Zoo()
    {
        Habitats = new List<Habitat>();
    }

    // The AddHabitat method is used to add a habitat to the zoo
    public void AddHabitat(Habitat habitat)
    {
        Habitats.Add(habitat);
    }

    // The FeedAllAnimals method is used to feed all animals in the zoo
    public void FeedAllAnimals()
    {
        foreach (var habitat in Habitats)
        {
            foreach (var animal in habitat.GetAnimals())
            {
                animal.Eat();
            }
        }
    }

    // The MakeAllAnimalsSound method is used to make all animals in the zoo make sound
    public void MakeAllAnimalsSound()
    {
        foreach (var habitat in Habitats)
        {
            foreach (var animal in habitat.GetAnimals())
            {
                if (animal is ISoundBehaviour soundMakingAnimal)
                {
                    soundMakingAnimal.MakeSound();
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Here we create a new zoo, create some habitats and animals, add the habitats to the zoo, and make the animals eat and make sound
        Zoo zoo = new Zoo();
        Habitat savannah = new Habitat("Savannah");
        Habitat jungle = new Habitat("Jungle");
        Habitat pond = new Habitat("Pond");

        zoo.AddHabitat(savannah);
        zoo.AddHabitat(jungle);
        zoo.AddHabitat(pond);

        Lion lion = new Lion("Simba", 5, savannah);
        Elephant elephant = new Elephant("Dumbo", 8, savannah);
        Monkey monkey = new Monkey("George", 3, jungle);
        Fish fish = new Fish("Nemo", 2, pond);

        zoo.FeedAllAnimals();
        zoo.MakeAllAnimalsSound();
    }
}
