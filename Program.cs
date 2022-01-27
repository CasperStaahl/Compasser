class Program
{
    static void Main(string[] args)
    {
        Compass compass = new Compass();
        View view = new View();
        Controller controller = new Controller(view, compass);
        controller.Run();
    }
}