using Course.Oop.Models;

namespace Course.Oop.Interface;

internal interface IRateable
{
    void AddRating(Rating rating);
    double GetAverageRating();
}
