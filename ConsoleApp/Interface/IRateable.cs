using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface;

internal interface IRateable
{
    IReadOnlyCollection<Rating> Ratings { get; }
    void AddRating(Rating rating);
    double GetAverageRating();
}
