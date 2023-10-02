using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_2
{
    internal class User
    {
        private string Login { get; }
        private string Name { get; }
        private string LastName { get; }
        private string Age { get; }
        private DateTime Data { get; }

        public User(string login, string name, string lastName, string age)
        {
            this.Login = login;
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
            this.Data = DateTime.Now;

            Console.WriteLine($"Ваш логін: {Login}\n Ваше ім'я: {Name}\n Ваша  фамілія: {LastName}\n Ваш вік: {Age}\n Час створення анкети: {Data}");
        }
    }
}
