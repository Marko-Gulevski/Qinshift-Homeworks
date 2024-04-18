using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Helpers

{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set; }

        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.Name);
            }
        }

        public void BuyPet(string petName)
        {
            T firstFoundNamedPet = Pets.FirstOrDefault(t => t.Name.ToLower() == petName.ToLower());
            if (firstFoundNamedPet == null)
            {
                Console.WriteLine($"Sorry, no such pet has been found in the database");
                return;
            }
            Pets.Remove(firstFoundNamedPet);
            Console.WriteLine($"You just purchased a {firstFoundNamedPet.GetType().Name}");
        }
    }
}
