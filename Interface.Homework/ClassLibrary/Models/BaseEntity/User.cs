using ClassLibrary.Interfaces;

namespace ClassLibrary.Models.BaseEntity
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Username { get; set; }

        public User(int id, string name, string username)
        {
            Id = id;
            Name = name;
            Username = username;
        }

        public abstract void PrintUser();
    }
}
