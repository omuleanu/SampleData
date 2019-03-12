using System;

namespace Omu.SampleData.Model
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}
