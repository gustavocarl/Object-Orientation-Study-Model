using Object_Orientation_Project;

Car car = new Car("Ford Fiesta", 2009, 4);

Console.WriteLine($"Modelo: {car.Model} - Ano de Fabricação: {car.Year} - Total de Portas: {car.NumberOfDoors}");

car.Start();
car.Move();
car.Stop();

Console.WriteLine("\n");

Plane plane = new Plane("Boeing 747", 2024, 4);
Console.WriteLine($"Modelo: {plane.Model} - Ano de Fabricação: {plane.Year} - Número de Motores: {plane.NumberOfEngines}");

plane.Start();
plane.Move();
plane.Stop();

Console.WriteLine("\n");

Boat boat = new Boat("Yamaha WaveRunner", 2022, false);
Console.WriteLine($"Modelo: {boat.Model} - Ano de Fabricação: {boat.Year} - Possui Velas: {boat.HasSails}");

boat.Start();
boat.Move();
boat.Stop();

Console.WriteLine("\n");