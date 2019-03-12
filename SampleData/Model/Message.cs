using System;

namespace Omu.SampleData.Model
{
    public class Message : Entity
    {
        public string From { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public DateTime DateReceived { get; set; }

        public bool IsRead { get; set; }
    }
}
