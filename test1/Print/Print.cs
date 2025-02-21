using DefineObject;

class Print
{
    public static Shape square = new("Square");
    public static void Main()
    {
        ISolidity solidity;
        Console.WriteLine(square.ToString());
        square.Defy("1","1");
        solidity = square;
        Console.WriteLine(square.ToString());
        square = new Shape("Rectangle");
        Console.WriteLine($"new shape got physical properties:\n{square.Physicality()}\n" +
                          $"And interface recalls it previous form:\n" +
                          $"{solidity.ToString()}");
        Console.Write("\nNew shape: ");
        Shape userShape = new(Console.ReadLine());
        Console.Write("Defy values of " + userShape.GetType().Name + "? YES|NO\n");
        string answer = Console.ReadLine();
        switch (answer.ToLower())
        {
            case "yes":
                Console.Write("Solidarity: ");
                string sol = Console.ReadLine();
                Console.Write("Density: ");
                string den = Console.ReadLine();
                userShape.Defy(sol, den);
                Console.WriteLine(userShape.ToString());
                break;
            default:
                Console.WriteLine(userShape.ToString());
                break;
        }
    }
}