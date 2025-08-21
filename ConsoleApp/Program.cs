// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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