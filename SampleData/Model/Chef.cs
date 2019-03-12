namespace Omu.SampleData.Model
{
    public class Chef : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
    }
}
