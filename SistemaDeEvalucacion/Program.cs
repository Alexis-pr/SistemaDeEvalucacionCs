// See https://aka.ms/new-console-template for more information

Console.WriteLine($@"Elige una opción
  1.   Nivel 1: Suma y validación numérica
  2.   Nivel 2: Cálculo y condicionales
  3.   Nivel 3: Manipulación de Cadenas
  4.   Nivel 4: Operaciones Lógicas (Calculadora)
  5.   Nivel 5: Análisis Numérico (Listas de enteros)
  6.   Nivel 6: Gestión de Tareas (Listas de cadenas)
  7.   Nivel 7: Arreglos y Búsqueda
  8.   Nivel 8: Programación Orientada a Objetos (Clases)
  9.   Nivel 9: CRUD de Objetos (Listas de objetos)
  10.  Salir
");

if (!int.TryParse(Console.ReadLine(), out int resultado))
{
    Console.WriteLine("digite un numero valido");
}

switch (resultado)
{
    case 1:
        
        Console.Write("Ingrese el primer numero:");
        int valor = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el segundo numero:");
        int valor2 = int.Parse(Console.ReadLine());
        
        Calculadora calculadora = new Calculadora();
        calculadora.suma(valor, valor2);
        break;
    case 2:
        Console.WriteLine("Ingrese la primera nota:");
        double nota1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la segunda nota:");
        double nota2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la tercera nota:");
        double nota3 = double.Parse(Console.ReadLine());
        
        Calculadora condicional = new Calculadora();
        condicional.condicional(nota1, nota2, nota3);
        
        break;  
    case 3:
        Console.WriteLine("Ingrese el Nombre :");
        string nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese el apellido :");
        string apellido = Console.ReadLine();
        Calculadora concatenar = new Calculadora();
        concatenar.ConcatenarNombre(nombre, apellido);
        break;
    case 4:
        Console.WriteLine(@$"Ingresa El numero de la operación que deseas realizar:
            1. Suma.
            2. Resta.
            3. Multiplicacion.
            4. Divicion.
        ");

        int resul = int.Parse(Console.ReadLine());
        
        Calculadora operacion = new Calculadora();
        operacion.Operaciones(resul);
        break;
}


class Calculadora
{
    // Nivel 1
    public int suma(int a, int b)
    {
        int resultado = a + b;
        Console.WriteLine($"El resultado es: {resultado}");
        return resultado;
    }
    // nivel 2
    public double condicional(double a, double b, double c)
    {
        double resultado = (a + b + c)/3;
        if (resultado < 3.0)
        {
            Console.WriteLine($"El resultado es: {resultado} y Es Reprobado");
            return resultado;
        }
        else
        {
            Console.WriteLine($"El resultado es: {resultado} y Es Aprobado"); 
            return resultado;
        }
      
    }
    
    //nivel 3
    public void ConcatenarNombre(string nombre, string apellido)
    {
        string result = nombre + " " + apellido; // no es la mejor forma pero la que funciono
        Console.WriteLine($"el nombre es {result}");
    }
    // nivel4

    public int Operaciones(int opcion )
    {
        
        
        int numero1  = 0;
        int numero2  = 0;
        int resultado = 0;
      
        
        switch (opcion)
        {
            case 1:
                Console.Write(@$"----------
                    Haz elegido la opción {opcion} de suma
                ----------
                 ");
                
                Console.Write("Ingresa el primer valor: ");
                
                numero1  = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el segundo valor: ");
                numero2  = int.Parse(Console.ReadLine());
                
                resultado = numero1 + numero2;
                Console.WriteLine(@$"El resultado es: {resultado}");
                return resultado;
                
            case 2:
                Console.Write(@$"----------
                       Haz elegido la opción {opcion} de Resta
                ----------
                 ");
                Console.Write("Ingresa el primer valor: ");
                numero1  = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el segundo valor: ");
                 numero2  = int.Parse(Console.ReadLine());
                
                resultado = numero1 - numero2;
                return resultado;
            case 3:
                Console.Write(@$"----------
                       Haz elegido la opción {opcion} de multiplicacion
                ----------
                 ");
                Console.Write("Ingresa el primer valor: ");
                 numero1  = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el segundo valor: ");
                 numero2  = int.Parse(Console.ReadLine());
                
                resultado = numero1 * numero2;
                return resultado;
            
            case 4:
                Console.Write(@$"----------
                       Haz elegido la opción {opcion} de división
                ----------
                 ");
                Console.Write("Ingresa el primer valor: ");
                 numero1  = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el segundo valor: ");
                 numero2  = int.Parse(Console.ReadLine());

                if (numero2 == 0)
                {
                    Console.Write("El numero 2 no puede ser cero");
                }

                

                
                resultado = numero1 / numero2;
                return resultado;
        }   
        
        return resultado;
    }
    
    
    
    
    
}







