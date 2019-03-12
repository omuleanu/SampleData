namespace Omu.SampleData.Model
{
    public class ParentMeal : Entity
    {
        public Category Category { get; set; }

        public Meal Meal { get; set; }
    }
}
