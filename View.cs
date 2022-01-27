class View
{
    public CompassDirection PromptNewNort()
    {
        Console.WriteLine("enter new north:");
        string? input = Console.ReadLine();
        CompassDirection direction;
        Enum.TryParse(input, out direction);
        return direction; 
    }

    public void DisplayDirection(CompassDirection direction, CompassDirection newDirection)
    {
        Console.WriteLine($"{direction.ToString()} = {newDirection.ToString()}");
    }
}
