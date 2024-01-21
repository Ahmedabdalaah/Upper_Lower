// See https://aka.ms/new-console-template for more information
using Upper_Lower;

Upper upper=new Upper();
Lower lower = new Lower();
Console.WriteLine("choose from the following");
Console.WriteLine(" a: convert lower case to Upper case");
Console.WriteLine(" b: convert Upper case to lower case");
try
{
    string choose = Console.ReadLine();
    if (choose == "a")
    {
        Console.WriteLine("please enter lower input");
        string input = Console.ReadLine();
        upper.toUpper(input);
    }
    else if(choose == "b")
    {
        Console.WriteLine("please enter upper input");
        string s= Console.ReadLine();
        lower.toLower(s);

    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }
}
catch( Exception ex)
{

}
