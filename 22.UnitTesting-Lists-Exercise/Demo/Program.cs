
//tuple

(int sideA, int sideB, int area) rectange = (3, 10, 0);

Console.WriteLine(rectange);
Console.WriteLine(rectange.sideA);
Console.WriteLine(rectange.sideB);
Console.WriteLine(rectange.area);

rectange.area = rectange.sideA * rectange.sideB;

Console.WriteLine(rectange.area);

// tuple

(int id, string name, double salary) employee = (1, "Dinko", 3200.50);

Console.WriteLine(employee.id);
Console.WriteLine(employee.name);
Console.WriteLine(employee.salary);



