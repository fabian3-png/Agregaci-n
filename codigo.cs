using System;

public class Departamento
{
  public string Nombre {get; set;}
  
  //Constructor que se llama igual que la clase Profesor, ademas de simplificarlo con "p"
  public void mostrarProfesor(Profesor p)
  {
      Console.WriteLine("Profesor:" + p.Nombre);
      Console.WriteLine("Departamento:" + Nombre);
  }
}

public class Profesor
{
    public string Nombre {get; set;}
}

class Program
{
    static void Main()
    {
        //nuevo objeto
       Profesor Juan= new Profesor();
       Juan.Nombre="Juan";
      
      //nuevo objeto
       Departamento Medicina= new Departamento();
       Medicina.Nombre= "Medicina";
       
       //mandar a llamar al metodo ubicado en Departamento
       Medicina. mostrarProfesor(Juan);
       
       
    }
}
