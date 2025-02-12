public class LISLogo {
public static void bootlogo1()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("╔═╗╦  ╦");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("  ┌─┐┌─┐┌┬┐┌─┐┌┐┌┌─┐┬┌┐┌┌─┐");
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.Write("║  ║  ║");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  │ ┬├─┤│││├┤ ││││ ┬││││├┤ ");
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.Write("╚═╝╩═╝╩");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  └─┘┴ ┴┴ ┴└─┘┘└┘└─┘┴┘└┘└─┘");
        Console.ResetColor();
    }
}