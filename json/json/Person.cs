using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsStudent { get; set; }

        public override string ToString()
        {
            return $"Name - {Name} Age - {Age} Email - {Email} Is a student - {IsStudent}";
        }
    }
}
