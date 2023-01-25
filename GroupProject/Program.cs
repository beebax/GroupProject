using GroupProject;

List<Person> people = new List<Person>()
{
    new Person("Wilfredo Pacheco", 26),
    new Person("Belle Baxley", 31),
    new Person("Tee Sotomi", 40)
};

foreach (Person p in people)
{
    Console.WriteLine($"{p.Name} is {p.Age} years old");
}