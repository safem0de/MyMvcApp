using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcApp.Models
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public string GroupCode { get; set; } = string.Empty;
        public ICollection<Studying> Studyings { get; set; } = new List<Studying>();
    }
}