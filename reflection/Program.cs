
using reflection;

Type tipo = typeof(Animal);
object instancia = Activator.CreateInstance(tipo);
var metodo = tipo.GetMethod("EmitirSom");
metodo.Invoke(instancia, new object[] { "Au Au" });
