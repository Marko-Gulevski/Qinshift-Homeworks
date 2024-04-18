using ClassLibrary.Interfaces;
using ClassLibrary.Models;
using ClassLibrary.Models.BaseEntity;


#region
Student studentOne = new(15, "David Angelov", "RavenclawForewver89", new int[] { 5, 4, 3, 5, 5 });
Student studentTwo = new(16, "Mia Melamori", "MementoMoriSiempre", new int[] { 5, 5, 5, 5, 4 });

Teacher theStrictOne = new(2, "Drska Drskovska", "ChemistryIsLifeXO", new string[] { "Chemistry", "Physics", "Geography", "History" });
Teacher theChillOne = new(3, "Mladen Chichakov", "FudbalJeZhivotJebote", new string[] { "PE", "Athletics", "First Aid", "Football Club" });

// Testing the methods
studentOne.PrintUser();
studentTwo.PrintUser();

studentOne.PrintGrades();
studentTwo.PrintGrades();

theStrictOne.PrintUser();
theChillOne.PrintUser();

theStrictOne.PrintSubjects();
theChillOne.PrintSubjects();
#endregion