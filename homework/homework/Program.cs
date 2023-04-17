using System.Runtime.CompilerServices;

Console.WriteLine("aylari qeyd edin");
string ay  = Console.ReadLine();
switch (ay)
{
    case "Yanvar":
    case "Fevral":
        case "Dekabr":
        Console.WriteLine("qis");
        break;
    case "mart":
    case "aprel":
    case "may":
        Console.WriteLine("Yaz");
        break;
    case "iyun":
    case "iyul":
    case "avgust":
        Console.WriteLine("yay");
        break;
    case "sentyabr":
    case "oktyabr":
    case "noyabr":
        Console.WriteLine("payiz");
        break;


    default:
        Console.WriteLine("duzgun fesil yazin");
        break;
        

}