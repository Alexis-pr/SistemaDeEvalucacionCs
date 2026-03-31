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
       
        
        Calculadora operacion = new Calculadora();
        operacion.Operaciones();
        break;
    case 5:
        Console.WriteLine("Ingresa 5 datos numericos: ");
        Calculadora listaN = new  Calculadora();
        listaN.listaNumerica();
        break;
    case 6:
        Calculadora listaS = new  Calculadora();
        listaS.listaStrings();
        break;
    case 7:
        Calculadora arreglosAndBusquedad = new Calculadora();
        arreglosAndBusquedad.arreglosYBusquedas();
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
    public void Operaciones( )
    {
        int numero1  = 0;
        int numero2  = 0;
        int resultado = 0;

        bool active = true;

        while (active)
        {
            Console.WriteLine(@$"Ingresa El numero de la operación que deseas realizar:
            1. Suma.
            2. Resta.
            3. Multiplicacion.
            4. Divicion.
            5. Salir.
             ");

            int opcion = int.Parse(Console.ReadLine());
        
        
        
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
                    break;
                    
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
                    Console.WriteLine($"El resultado es: {resultado} ");
                    break;
                    
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
                    Console.WriteLine($"El resultado es: {resultado} ");
                    break;
                
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
                        Console.WriteLine("El numero 2 no puede ser cero");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"El resultado es: {resultado} ");
                    }
                    break;
                case 5:
                    active = false;
                    break;
            }   
            
        
        }
    }
    
    // nivel 5
    public void listaNumerica()
    {
       int r = 0;
       int mayor = int.MinValue;
       int menor = int.MaxValue;
      
       int rTotal = 0;
        List<int> CountNumeric = new List<int>();
        
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"esta es la ronda {i}/5");
            r = int.Parse(Console.ReadLine());
            CountNumeric.Add(r);
        }
        Console.WriteLine($"los numeros dentro del listado son {CountNumeric.Count} ");
        
        foreach (int n in CountNumeric)
        {
            Console.Write($"[{n}]");
            if (n > mayor)
            {
                mayor = n;
            }
            if (n < menor)
            {
                menor = n;
            }
            
            rTotal +=n;
            
            
        }
        Console.WriteLine(@$" La suma total es: {rTotal}
        El numero mayor es: {mayor} 
        El numero menor es: {menor}
        ");
       

    }
    
    //nivel 6
    public void listaStrings()
    {
        bool contiene = true;
         List<string> tareas = new List<string>();
         while (contiene)
         {
             Console.WriteLine(@$"Ingresa El numero de la operación que deseas realizar:
            1. Agregar Tarea.
            2. Ver tareas.
            3. Eliminar tarea.
            4. Salir.          
            ");
             
         
             int res = int.Parse(Console.ReadLine());
             switch (res)
             {
                 case 1:
                     AgregarTarea();
                     break;
                 case 2:
                     VerTarea();
                     break;
                 case 3:
                     EliminarTarea();
                     break;
                 case 4:
                     contiene = false;
                     break;
             }
         }
        

        void AgregarTarea()
        {   
            Console.WriteLine("Agregar una nueva tarea ");
            string tareanueva = Console.ReadLine();
            
            tareas.Add(tareanueva); 
           Console.WriteLine("La tarea Ha sido AGREGADA  ✅  ");
        }

        void VerTarea()
        {
            Console.WriteLine($"-------------------------------------" +
                                     $"Las tareas disponibles son:" +
                              $"-------------------------------------");
            /*for (int i = 1; i < tareas.Count(); i++)
            {
                Console.WriteLine($"{tareas[i]} - {tareas[i - 1]}");
            }*/
            foreach (var tarea in tareas)
            {
                
                Console.WriteLine($"{tarea}");
                
            }
        }
        
        void EliminarTarea()
        {
            VerTarea();
            
            Console.WriteLine($"Seleccione el ID que desea borrar  ");
            int id = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < tareas.Count(); ++i)
            {
                if (id == i)
                {
                    tareas.RemoveAt(i);  
                    Console.WriteLine($"El tarea ha sido eliminado correctamente ✅ ");
                }
                else
                {
                    Console.WriteLine($"El tarea no existe el ID {id}");
                }
            }
            
            
        }
       
    }

    //nivel 7
    public void arreglosYBusquedas()
    {
         /*string[] ciudades = {"Medellin", "Bogota", " Pereira", "cartagena"};*/
        
         string[] ciudades = new string[]
        {
            "Medellin", "Bogota", " Pereira", "cartagena","manizales"
        };

        
        Console.WriteLine("Solicita una ciudad");
        string nombreCiudad = Console.ReadLine();
        bool existe = false;

        foreach (var ciudad in ciudades)
        {
            if (ciudad == nombreCiudad)
            {
                Console.WriteLine($"El ciudad Existe y es {ciudad}");
                existe = true;
                break;
            }
           
        }
        if (!existe)
        {
            Console.WriteLine("La ciudad no existe");
        }

    }
    
}







