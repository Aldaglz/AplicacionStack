using ADTLibrary;

IStack<Instrumento> pila = new StackList<Instrumento>();
var controller = new Controller(pila);

while (true)
{
    Console.WriteLine("GESTION DE INSTRUMENTOS");
    Console.WriteLine("1. Agregar instrumento");
    Console.WriteLine("2. Sacar instrumento");
    Console.WriteLine("3. Ver último instrumento");
    Console.WriteLine("4. Contar instrumentos");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

    var op = Console.ReadLine()?.Trim();
    Console.WriteLine();


    switch (op)
    {
        case "1":
            Console.Write("Número de serie: ");
            var serie = Console.ReadLine() ?? "";
            Console.Write("Modelo: ");
            var modelo = Console.ReadLine() ?? "";
            controller.AgregarInstrumento(serie, modelo);
            Console.WriteLine("Instrumento agregado.\n");
            break;

        case "2":
            var sacado = controller.SacarInstrumento();
            Console.WriteLine($"Sacado: {sacado}\n");
            break;

        case "3":
            var ultimo = controller.VerUltimo();
            Console.WriteLine($"Último en la pila: {ultimo}\n");
            break;

        case "4":
            Console.WriteLine($"Total = {controller.ContarInstrumentos()}\n");
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Opción no válida.\n");
            break;
    }
}