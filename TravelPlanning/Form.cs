using System;
using System.Collections.Generic;

namespace TravelPlanning
{
    public partial class Form
    {
        public int Id { get; set; }
        public DateTime DateOfDeparture { get; set; }
        public DateTime DateOfArrival { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public string Location { get; set; } = null!;
        public string TypeOfStay { get; set; } = null!;
        public string Transportation { get; set; } = null!;
        public double Budget { get; set; }
    }
}
