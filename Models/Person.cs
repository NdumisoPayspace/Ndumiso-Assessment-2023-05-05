namespace Ndumiso_Assessment_2023_05_05.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    public static class MockData
    {
        public static List<Person> people = new List<Person>()
        {
            new Person { Id = 1, Name = "Annie", Age = 18 },
            new Person { Id = 2, Name = "Lewis", Age = 20 },
            new Person { Id = 3, Name = "Fernando", Age = 21 },
            new Person { Id = 4, Name = "Max", Age = 78 },
            new Person { Id = 5, Name = "George", Age = 45 },
            new Person { Id = 6, Name = "Bottas", Age = 32 },
            new Person { Id = 7, Name = "Estaban", Age = 94 },
            new Person { Id = 8, Name = "Lando", Age = 48 },
            new Person { Id = 9, Name = "Charles", Age = 8 },
            new Person { Id = 10, Name = "Sergio", Age = 13 },
            new Person { Id = 11, Name = "Ocon", Age = 10 }
        };
    }
}
