using ClassLibrary.Helpers;
using ClassLibrary.Models;
using ClassLibrary.Models.BaseEntity;

#region 
PetStore<Dog> dogStore = new PetStore<Dog>()
{
    Pets = new List<Dog>() { new("Abraham", "Doberman", 11, false, "Mushrooms"), new("Zoe", "French Poodle", 3, true, "Doggy Biscuits") }
};

PetStore<Cat> catStore = new PetStore<Cat>()
{
    Pets = new List<Cat>() { new("Fae", "Siamese Cat", 13, false, 6),
        new("Ronnie", "Persian Cat", 4, false, 8) }
};

PetStore<Fish> fishStore = new PetStore<Fish>()
{
    Pets = new List<Fish>()
    {
        new("Nemo","Swordfish",1,"Gray","Medium"),
        new("Anakin","Anglerfish",4,"Orange","Large")
    }
};

// Listing
dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();

// Buying and selling

dogStore.BuyPet("Abraham");
catStore.BuyPet("Ronnie");
dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();
#endregion