using Interface;

IPerson person = new Person("Gustavo Henrique", "Carl Dos Santos", "gustavo_carl@hotmail.com", 37, "(16) 99760-5799");

Console.WriteLine($"{person.FirstName} é considerado adulto? {person.IsAdult(person.Age)}");
Console.WriteLine(person.PrintPerson());