using System.Collections.Generic;

namespace csv.Models
{
    public class Family
    {
        public Father Father { get; set; }
        public Mother Mother { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
