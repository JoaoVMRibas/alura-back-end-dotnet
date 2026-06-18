namespace Course.Oop.Models;

internal class Rating
{
    public int Value { get; }

    public Rating(int value)
    {
        if(value < 0 || value > 5)
            throw new ArgumentOutOfRangeException(nameof(value), "The rating should be between 1 and 5.");

        Value = value;
    }
}
