using ScreenSound.Models;

namespace ScreenSound.Interface;

internal interface IRateable
{
    void AddRating(Rating rating);
    double GetAverageRating();
}
