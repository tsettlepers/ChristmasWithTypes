using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //DONE - TODO Make the Height property nullable

        //DONE - TODO Make the property, "Day", type enum
        public enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    }
}
