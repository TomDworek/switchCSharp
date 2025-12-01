Console.WriteLine("Skriv en tall mellom 1 til 7:");

string? input = Console.ReadLine();

if (!int.TryParse(input, out int dag))
{
    Console.WriteLine("Ugyldig input, vennligst skriv et tall mellom 1 og 7.");
}
else
{
    switch (dag)
    {
        case 1:
            Console.WriteLine("Mandag");
            break;
        case 2:
            Console.WriteLine("Tirsdag");
            break;
        case 3:
            Console.WriteLine("Onsdag");
            break;
        case 4:
            Console.WriteLine("Torsdag");
            break;
        case 5:
            Console.WriteLine("Fredag");
            break;
        case 6:
            Console.WriteLine("Lørdag");
            break;
        case 7:
            Console.WriteLine("Søndag");
            break;
        default:
            Console.WriteLine("Ugyldig tall, vennligst skriv et tall mellom 1 og 7.");
            break;
    }
}