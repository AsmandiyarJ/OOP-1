using OOP;
People people = new People();
Console.WriteLine("Введите свой возраст");
people.age = int.Parse(Console.ReadLine());
Console.WriteLine("Введите свое Фамилия");
people.surname = Console.ReadLine();
Console.WriteLine("Введите свое имя");
people.name = Console.ReadLine();


people.Setage(people.age);
people.SetSurname(people.surname);
people.Setname(people.name);
people.Print(people.age, people.surname,people.name);




