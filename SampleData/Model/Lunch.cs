using System;

namespace Omu.SampleData.Model
{
    public class Lunch : Entity
    {
        public string Person { get; set; }
        public string Food { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public Country Country { get; set; }
        public Chef Chef { get; set; }
        public bool Organic { get; set; }
        public string FoodPic { get; set; }
    }
}
