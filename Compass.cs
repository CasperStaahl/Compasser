class CompassModel
{
    public CompassDirection NewNorth { get; set; } = CompassDirection.N;
    public CompassDirection GetDirectionRelativeToNewNorth(CompassDirection direction)
    {
        return (CompassDirection)(((int)direction + (int)NewNorth) % 32);
    }
}
