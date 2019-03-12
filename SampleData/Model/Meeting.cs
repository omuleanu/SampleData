using System;

namespace Omu.SampleData.Model
{
    public class Meeting : Entity
    {
        public string Title { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Location { get; set; }

        public string Color { get; set; }

        public string Notes { get; set; }

        public bool AllDay { get; set; }
    }
}
