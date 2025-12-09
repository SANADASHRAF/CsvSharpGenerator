using System.Collections.Generic;

namespace csv.Models
{
    public class StudentsDistributionConfig
    {
        public List<Stage> Stages { get; set; } = new List<Stage>();
    }

    public class Stage
    {
        public string StageName { get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }

    public class Grade
    {
        public string GradeName { get; set; }
        public List<Class> Classes { get; set; } = new List<Class>();
    }

    public class Class
    {
        public string ClassName { get; set; }
        public int StudentCount { get; set; }
    }
}
