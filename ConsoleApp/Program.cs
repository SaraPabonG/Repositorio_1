// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var trabajador= new Trabajadores();
Trabajadores trabajador1 = new Trabajadores();
Trabajadores trabajador2 = new Empleados();

trabajador.id = 1;
trabajador.Nombre = "Luis";
trabajador.Apellido = "Goméz";
trabajador.Cargo = "Mécanico";
trabajador.Edad = 35;
trabajador.Estatura = 1.75m;
trabajador.Salario = 320000m;
trabajador.Vive = true;
trabajador.Fecha = DateTime.Now;
trabajador.Estado = new Estados() { id = 1, Nombre = "Casado" };
trabajador.Videojuegos = new List<Videojuegos>();
trabajador.Videojuegos.Add(new Videojuegos() {id = 1, Nombre = "LOZ 2025"});
trabajador.Videojuegos.Add(new Videojuegos() {id = 2, Nombre = "Tetrix"});

Console.WriteLine(trabajador.Nombre);
Console.WriteLine(trabajador.Estado.Nombre);

foreach (var elemento in trabajador.Videojuegos){
    Console.WriteLine(elemento.Nombre);
}//Fin for each

public class Estados
{
    public int id = 0;
    public String? Nombre = "";
}//Fin Estados

public class Videojuegos{
    public int id = 0;
    public String? Nombre = ""; 
}//Fin Videojuegos

public class Trabajadores
{
    public int id = 0, Edad;
    public String? Nombre, Apellido, Cargo;
    public decimal Estatura, Salario = 0.0m;
    public bool Vive = false;
    public DateTime Fecha;
    public Estados? Estado = new Estados();
    public List<Videojuegos> Videojuegos = new List<Videojuegos>();
}//Fin Trabajadores

public class Empleados : Trabajadores{
    public String? Carnet;
}//Fin Empleados