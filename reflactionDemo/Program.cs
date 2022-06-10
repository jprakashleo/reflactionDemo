//Reflection is a feature of .NET which helps reflect an assembly and its types.
////We can use reflection to dynamically browse through all the types defined inside of an assembly. 
using System.Reflection;

Console.WriteLine("Hello, World!");

var assembly = Assembly.LoadFrom(@"C:\Users\91774\VS\source\reflactionDemo\PrintAll\bin\Debug\net6.0\PrintAll.dll");

foreach (var type in assembly.GetTypes())
{
    Console.WriteLine($"type is :{type.Name}");
    //Console.WriteLine("================================");
    foreach (var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly))
    {
        Console.WriteLine($"field is :{field.Name}");

    }
    Console.WriteLine("================================");
    foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
    {
        Console.WriteLine($"method is {method.Name}");
    }
    Console.WriteLine("================================");

    foreach (var propery in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic| BindingFlags.Instance|BindingFlags.Static))
    {
        Console.WriteLine($"peroperty is {propery.Name}");
    }
    Console.WriteLine("================================");

}
