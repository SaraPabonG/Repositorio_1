// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Trabajadores trabajador = new Trabajadores();
trabajador.id = 1;
trabajador.Nombre = "Luis";
trabajador.Apellido = "Goméz";
trabajador.Cargo = "Mécanico";
trabajador.Edad = 35;
trabajador.Estatura = 1.75m;
trabajador.Salario = 320000m;
trabajador.Vive = true;
trabajador.Fecha = DateTime.Now;
trabajador.Estado = new Estados() {id = 1, Nombre = "Casado"};

public class Estados{
    public int id;
    public string? Nombre;
}//Fin Estados

public class Trabajadores{
    public int id, Edad;
    public string? Nombre, Apellido, Cargo;
    public decimal Estatura, Salario;
    public bool Vive;
    public DateTime Fecha;
    public Estados? Estado;
}//Fin Trabajadores

public class Empleados : Trabajadores{
    public string? Carnet;
}//Fin Empleados