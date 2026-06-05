using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface;

internal interface IRateable
{
    IReadOnlyCollection<int> Ratings { get; }
    void AddRating(int rating);
    double GetAverageRating();
}
