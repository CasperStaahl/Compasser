class Program
{
    static void Main(string[] args)
    {
        CompassModel compass = new CompassModel();
        View view = new View();
        Controller controller = new Controller(view, compass);
        controller.Run();
    }
}