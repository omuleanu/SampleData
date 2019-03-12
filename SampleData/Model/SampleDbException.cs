using System;

namespace Omu.SampleData.Model
{
    public class SampleDbException : Exception
    {
        public SampleDbException()
        {
        }

        public SampleDbException(string message) : base(message)
        {
        }
    }
}
