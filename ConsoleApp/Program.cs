//Función para calcular la suma de 2 números enteros
static int Suma(int a, int b)
{
    return a + b;
}

static int Resta(int a, int b)
{
    return a - b;
}

static int Multiplicacion(int a, int b)
{
    return a * b;
}

static int Division(int a, int b)
{
    return a / b;
}

static void Raiz()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
    }
}

static void NumPrim()
{
    int count = 0;
    for (int i = 2; i <= 30; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0)
            {
                count = count + 1;
            }
        }
        if (count <= 2)
        {
            Console.WriteLine(i);
        }
        count = 0;
    }
}

static int ConvertirT(string T, int value)
{

    if(T == "C")
    {
        return ((5 * (value - 32)) )/ 9;
    }
    else
    {
        return (((9 * value)) / 5) + 32;
    }

}

Console.Title = "Procedimientos y funciones";
string opcion;
do
{
    Console.Clear();
    Console.WriteLine("[1] Suma de dos números");
    Console.WriteLine("[2] Resta de dos números");
    Console.WriteLine("[3] Multiplicación de dos números");
    Console.WriteLine("[4] División de dos números");
    Console.WriteLine("[5] 10 primeros numeros primos");
    Console.WriteLine("[6] Convertir a grados C o F");
    Console.WriteLine("[7] Imprimir la raíz cuadrada de los 10 primeros números enteros");
    Console.WriteLine("[0] Salir");
    Console.WriteLine("Ingrese una opción y presione ENTER");
    opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el primer número");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("Ingrese el primer número");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("Ingrese el primer número");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("Ingrese el primer número");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La división de {0} y {1} es {2}", g, h, Division(g, h));
            Console.ReadKey();
            break;
        case "5":
            Console.WriteLine("Los 10 primeros numeros primos");
            NumPrim();
            Console.ReadKey();
            break;
        case "6":
            Console.WriteLine("A que grado desea convertir C o F?");
            string t = Console.ReadLine();
            Console.WriteLine("Ingrese el valor");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La conversion a {0} es {1}", t, ConvertirT(t,v));
            Console.ReadKey();
            break;
        case "7":
            Console.WriteLine("Calculando...");
            Raiz();
            Console.ReadKey();
            break;
    }
} while (!opcion.Equals("0"));