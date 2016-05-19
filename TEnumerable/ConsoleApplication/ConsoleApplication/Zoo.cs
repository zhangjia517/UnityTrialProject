using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Zoo : IEnumerable
    {
        private List<Animal> animals = new List<Animal>();

        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            foreach (Animal theAnimal in animals)
            {
                yield return theAnimal.Name;
            }
        }

        public IEnumerable Birds
        {
            get { return AnimalsForType(Animal.TypeEnum.Bird); }
        }

        public IEnumerable Mammals
        {
            get { return AnimalsForType(Animal.TypeEnum.Mammal); }
        }

        public void AddBird(string name)
        {
            animals.Add(new Animal { Name = name, Type = Animal.TypeEnum.Bird });
        }

        public void AddMammal(string name)
        {
            animals.Add(new Animal { Name = name, Type = Animal.TypeEnum.Mammal });
        }

        private IEnumerable AnimalsForType(Animal.TypeEnum type)
        {
            foreach (Animal theAnimal in animals)
            {
                if (theAnimal.Type == type)
                {
                    yield return theAnimal.Name;
                }
            }
        }

        private class Animal
        {
            public enum TypeEnum { Bird, Mammal }

            public string Name { get; set; }
            public TypeEnum Type { get; set; }
        }
    }
}