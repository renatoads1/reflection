
using reflection;
using System.Reflection;

Type tipo = typeof(Animal);
Console.WriteLine($"📌 Tipo: {tipo.FullName}");
Console.WriteLine($"Herda de: {tipo.BaseType}");

Console.WriteLine("\n🔹 Atributos:");
foreach (var attr in tipo.GetCustomAttributes())
{
    Console.WriteLine($" - {attr.GetType().Name}");
}

// Construtores
Console.WriteLine("\n🔹 Construtores:");
foreach (var ctor in tipo.GetConstructors(
    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine($" - {ctor}");
}

// Campos
Console.WriteLine("\n🔹 Campos:");
foreach (var campo in tipo.GetFields(
    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine($" - {campo.FieldType.Name} {campo.Name}");
}

// Propriedades
Console.WriteLine("\n🔹 Propriedades:");
foreach (var prop in tipo.GetProperties(
    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine($" - {prop.PropertyType.Name} {prop.Name}");
}

// Métodos
Console.WriteLine("\n🔹 Métodos:");
foreach (var metod in tipo.GetMethods(
    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
{
    Console.WriteLine($" - {metod.ReturnType.Name} {metod.Name}()");
}

// Eventos
Console.WriteLine("\n🔹 Eventos:");
foreach (var ev in tipo.GetEvents(
    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
{
    Console.WriteLine($" - {ev.EventHandlerType.Name} {ev.Name}");
}

// Interfaces
Console.WriteLine("\n🔹 Interfaces:");
foreach (var iface in tipo.GetInterfaces())
{
    Console.WriteLine($" - {iface.Name}");
}

object instancia = Activator.CreateInstance(tipo);

var metodo = tipo.GetMethod("EmitirSom");

metodo.Invoke(instancia, new object[] { "Au Au" });
