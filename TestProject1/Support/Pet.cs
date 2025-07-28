using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationConcepts.Support
{

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Pet
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public List<string> PhotoUrls { get; set; }

        public Category Category { get; set; }

        public List <Tag> Tags { get; set; }
    }
}
