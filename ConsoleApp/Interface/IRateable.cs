using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface;

internal interface IRateable
{
    void AddRating(Rating rating);
    double GetAverageRating();
}
