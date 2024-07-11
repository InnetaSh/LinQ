
//Напишите LINQ-запрос, который отбирает все четные числа из списка чисел.


using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<int> nums = new List<int> {3,5,87,26,45,11,12,17,21,22,23};
var ChetneNums = nums.Where(x=>x%2==0).ToList();

foreach (var n in ChetneNums)
{
    Console.Write(n + "\t");
}
Console.WriteLine();
Console.WriteLine("----------------------------------------------------");






//Напишите LINQ-запрос, который отбирает все строки длиной больше 3 символов из списка строк.

//List<string> strings = new List<string> { "который", "отбирает", "все", "строки", "длиной", "больше", "3", "символов", "из", "списка", " строк." };
//var list = strings.Where(x=>x.Length > 3).ToList();

//foreach (var l in list)
//{
//    Console.Write(l + " ");
//}
//Console.WriteLine();
//Console.WriteLine("----------------------------------------------------");








//Напишите LINQ-запрос, который отбирает все объекты класса Person, у которых возраст больше 18 лет.

//var people = new List<Person>
//{
//    new Person("Alex",23),
//    new Person("Tom",8),
//    new Person("Sam",12),
//    new Person("Bob",41),
//};

//var peopleList = people.Where(x => x.Age > 18);

//foreach (var person in peopleList)
//{
//    Console.WriteLine($"name - {person.Name}, age - {person.Age}");
//}
//record class Person(string Name, int Age);






//Напишите LINQ-запрос, который отбирает все числа больше 10 и меньше 50 из списка чисел.

//List<int> nums2 = new List<int> { 300, 15, 87, 26, 45, 11, 12, 127, 201, 22, 23 };

//var Nums2 = nums2.Where(x => (x > 0 && x < 50)).ToList();
//foreach (var n in Nums2)
//{
//    Console.Write(n + "\t");
//}
//Console.WriteLine();
//Console.WriteLine("----------------------------------------------------");

////Напишите LINQ-запрос, который отбирает все строки, начинающиеся с буквы "A", и преобразует их в верхний регистр.

//List<string> strings2 = new List<string> { "Апельсин", "яблоко", "Ананас", "кокос", "персик", "Абрикос",  "из", "списка", " строк." };
//var list2 = strings2.Where(p=>p.StartsWith("А")).Select(p=>p.ToUpper()).ToList();

//foreach (var l in list2)
//{
//    Console.Write(l + " ");
//}
//Console.WriteLine();
//Console.WriteLine("----------------------------------------------------");








//Напишите LINQ-запрос, который отбирает все объекты класса Order, у которых есть хотя бы один товар с ценой больше 100.


//var Orders = new List<Order>
//{  
//    new Order(1,"апельсин", 150),
//    new Order(2,"яблоко",50),
//    new Order(3,"Ананас",200),
//    new Order(4,"манго",300),
//    new Order(5,"Абрикос",45),
//};

//var orderList = Orders.Where(x => x.Price > 100);
//foreach (var order in orderList)
//{
//    Console.WriteLine($"Id - {order.Id},  Name - {order.Name},  Price = {order.Price}");
//}
//public class Order
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Price { get; set; }

//    public Order(int id, string name, int price)
//    {
//        Id = id;
//        Name = name;
//        Price = price;
//    }
//}


//Напишите LINQ-запрос, который отбирает все числа из списка, которые являются простыми.

//List<int> nums3 = new List<int> { 311, 15, 87, 26, 47, 11, 12, 101, 201, 22, 13 };


//var Nums3 = nums3.Where(x => ProsteNums(x)).ToList();
//foreach (var n in Nums3)
//{
//    Console.Write(n + "\t");
//}
//Console.WriteLine();
//Console.WriteLine("----------------------------------------------------");
//bool ProsteNums(int num)
//{
//    for (int i = 2; i < Math.Sqrt(num); i++)
//    {
//        if (num % i == 0)
//            return false;
//    }
//    return true;
//}





//Напишите LINQ-запрос, который группирует строки по первой букве и отбирает группы, содержащие более двух элементов.


//List<string> strings3 = new List<string> { "апельсин", "яблоко", "ананас", "кокос", "персик", "Абрикос", "манго", "киви", "арбуз","клубника" ,"маракуя", "морковь"};


//var groups = strings3.GroupBy(x => x.ToLower()[0]).Where(group => group.Count() > 2);


//var strToLower = strings3.Select(x => x.ToLower()).ToList();
//var groups2 = strToLower.GroupBy(x => x[0]).Where(group => group.Count() > 2);


//foreach (var g in groups)
//{
//    Console.WriteLine($"Группа по первой букве '{g.Key}' содержит {g.Count()} элементов:");
//    foreach (var word in g)
//    {
//        Console.WriteLine(word);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//foreach (var g in groups2)
//{
//    Console.WriteLine($"Группа по первой букве '{g.Key}' содержит {g.Count()} элементов:");
//    foreach (var word in g)
//    {
//        Console.WriteLine(word);
//    }
//    Console.WriteLine();
//}







//Напишите LINQ-запрос, который отбирает все объекты класса Employee, у которых зарплата больше 50000 и они работают в отделе "IT".


//var EmployeeList = new List<Employee>
//{
//    new Employee("Alex",23000,"IT"),
//    new Employee("Tom",80000,"IT"),
//    new Employee("Sam",12000,"Marketing"),
//    new Employee("Bob",141000,"IT"),
//    new Employee("Anna",100000,"Marketing"),
//};

//var EmployeeListNew = EmployeeList.Where(x => x.Salary > 50000 && x.Department == "IT");

//foreach (var emp in EmployeeListNew)
//{
//    Console.WriteLine($"Name - {emp.Name},  Salary - {emp.Salary},  Department = {emp.Department}");
//}
//public class Employee
//{
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public string Department { get; set; }

//    public Employee(string name, int salary, string department)
//    {
//        Name = name;
//        Salary = salary;
//        Department = department;
//    }
//}









//Напишите LINQ-запрос, который отбирает все заказы, сделанные в 2023 году, и вычисляет общую сумму всех таких заказов.

//var Orders2 = new List<Order2>
//{
//    new Order2(1,"компьютер", 55000, 2023),
//    new Order2(2,"телефон Sumsung",2100,2022),
//    new Order2(3,"телефон Iphon",47800,2023),
//    new Order2(4,"клавиатура",1300,2023),
//    new Order2(5,"наушники",2450,2020),
//};

//var OrdersPrice = Orders2.Where(x => x.Year == 2023).Sum(x => x.Price);


//Console.WriteLine($"сумма заказов за 2023 год = {OrdersPrice}.");

//public class Order2
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Price { get; set; }
//    public int Year { get; set; }

//    public Order2(int id, string name, int price,int year)
//    {
//        Id = id;
//        Name = name;
//        Price = price;
//        Year = year;
//    }
//}