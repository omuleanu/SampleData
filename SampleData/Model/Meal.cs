namespace Omu.SampleData.Model
{
    public class Meal : Entity
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
