using System;
using System.Collections.Generic;

namespace Omu.SampleData.Model
{
    public class Dinner : Entity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Chef Chef { get; set; }
        public Country Country { get; set; }
        public IEnumerable<Meal> Meals { get; set; }
        public Meal BonusMeal { get; set; }
        public string Comments { get; set; }
        public bool Organic { get; set; }
    }
}
