using System;

namespace CodeStyleCheckSample
{
    public class myClass
    {
        // Public field
        public string PublicField = "Foo";

        // Private property casing
        private string privateProp => "Qux";

        public void foo()
        {
            // Block without braces
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
                Console.WriteLine("Yay, it's Friday!");

            // If without a trailing space
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("It's Monday (︶︿︶)");
            }

            // Wrong indentation
                Console.WriteLine("Bar");
            
            // Tabs instead of spaces
        	Console.WriteLine("Baz");
        }
    }
}
