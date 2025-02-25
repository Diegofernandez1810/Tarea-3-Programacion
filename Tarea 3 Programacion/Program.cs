using System;
using System.Collections.Generic;

class Program
{
    // Método para calcular ingresos y promedio
    static void CalcularIngresos()
    {
        Console.WriteLine("Ingresa tu nombre:");
        string nombre = Console.ReadLine();

        double[] ingresos = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Ingresa los ingresos del mes {i + 1}:");
            ingresos[i] = Convert.ToDouble(Console.ReadLine());
        }

        double suma = ingresos[0] + ingresos[1] + ingresos[2];
        double promedio = suma / 3;

        Console.WriteLine($"Hola {nombre}, en total ganaste {suma} y promediaste {promedio}.");
    }

    // Clase con operaciones básicas
    class OperacionesBasicas
    {
        public static int Sumar(int a, int b) => a + b;
        public static int Restar(int a, int b) => a - b;
        public static int Multiplicar(int a, int b) => a * b;
        public static int Dividir(int a, int b) => a / b;
    }

    // Método para sumar dos valores con manejo de excepciones
    static void SumarConTryCatch()
    {
        try
        {
            Console.WriteLine("Ingresa el primer valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = valor1 + valor2;
            Console.WriteLine($"La suma es: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operación finalizada.");
        }
    }

    // Sistema de inicio de sesión
    static Dictionary<string, string> usuariosRegistrados = new Dictionary<string, string>();

    static void RegistrarUsuario()
    {
        Console.WriteLine("Registro de nuevo usuario:");
        Console.WriteLine("Ingresa un nombre de usuario:");
        string usuario = Console.ReadLine();
        Console.WriteLine("Ingresa una contraseña:");
        string contraseña = Console.ReadLine();

        usuariosRegistrados[usuario] = contraseña;
        Console.WriteLine("Usuario registrado con éxito.");
    }

    static void IniciarSesion()
    {
        Console.WriteLine("Inicio de sesión:");
        Console.WriteLine("Ingresa tu nombre de usuario:");
        string usuario = Console.ReadLine();
        Console.WriteLine("Ingresa tu contraseña:");
        string contraseña = Console.ReadLine();

        if (usuariosRegistrados.ContainsKey(usuario) && usuariosRegistrados[usuario] == contraseña)
        {
            Console.WriteLine("Inicio de sesión exitoso.");
        }
        else
        {
            Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
        }
    }

    // Manejo de puntajes de un juego
    static int puntajeRecord = 0;
    static string jugadorRecord = "";

    static void VerificarPuntaje(int puntaje, string jugador)
    {
        if (puntaje > puntajeRecord)
        {
            puntajeRecord = puntaje;
            jugadorRecord = jugador;
            Console.WriteLine($"La nueva puntuación más alta es {puntajeRecord}.");
            Console.WriteLine($"La puntuación más alta fue lograda por {jugadorRecord}.");
        }
        else
        {
            Console.WriteLine($"La puntuación más alta de {puntajeRecord} no se ha podido superar, y aún está en manos de {jugadorRecord}.");
        }
    }

    static void Main(string[] args)
    {
        // Ejercicio 1
        CalcularIngresos();

        // Ejercicio 2
        Console.WriteLine("Suma: " + OperacionesBasicas.Sumar(10, 5));
        Console.WriteLine("Resta: " + OperacionesBasicas.Restar(10, 5));
        Console.WriteLine("Multiplicación: " + OperacionesBasicas.Multiplicar(10, 5));
        Console.WriteLine("División: " + OperacionesBasicas.Dividir(10, 5));

        // Ejercicio 3
        SumarConTryCatch();

        // Ejercicio 4
        RegistrarUsuario();
        IniciarSesion();

        // Ejercicio 5
        VerificarPuntaje(100, "Jugador1");
        VerificarPuntaje(150, "Jugador2");
        VerificarPuntaje(120, "Jugador3");
    }
}
