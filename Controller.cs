class Controller
{
    View _view;
    CompassModel _compass;

    public Controller(View view, CompassModel compass)
    {
        _view = view;
        _compass = compass;
    }

    public void Run()
    {
        CompassDirection newNorth = _view.PromptNewNort();
        _compass.NewNorth = newNorth;

        foreach (CompassDirection direction in (CompassDirection[])Enum.GetValues(typeof(CompassDirection)))
        {
            _view.DisplayDirection(direction, _compass.GetDirectionRelativeToNewNorth(direction));
        }
    }
}