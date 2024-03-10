namespace AppSinHilos;

class Program
{

    public static void DoTrabajoPesado()
    {
        Console.WriteLine("DoTrabajoPesado: Estoy levantando un camión!");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: Cansado! Necesito una siesta de 3 seg");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 1...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 2...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 3...");
        Console.WriteLine("DoTrabajoPesado: Ya desperté");
    }

    public static void DoAlgo()
    {
        Console.WriteLine("DoAlgo: Hey! Haciendo algo aquí");

        for (int i = 0; i < 20; i++)
            Console.Write($"{i}" );
            
        Console.WriteLine();
        Console.WriteLine("DoAlgo: Ya terminé");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Cristopher Vázquez Villa: Desarrollo de sistemas en red \n");

        Console.WriteLine("El main thread comienza aquí:");
        Program.DoTrabajoPesado();
        Program.DoAlgo();

        Console.WriteLine("\n El main thread termina aquí");
        Console.WriteLine("\n Presione cualquier tecla para terminar...");
        Console.ReadKey(true);
    }
}
