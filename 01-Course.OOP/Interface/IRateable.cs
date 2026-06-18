using Course.OOP.Models;

namespace Course.OOP.Interface;

internal interface IRateable
{
    void AddRating(Rating rating);
    double GetAverageRating();
}
