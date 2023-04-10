namespace BugReproduction;

internal class Program : MauiApplication
{
    private static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }

    protected override MauiApp CreateMauiApp()
    {
        return MauiProgram.CreateMauiApp();
    }
}
