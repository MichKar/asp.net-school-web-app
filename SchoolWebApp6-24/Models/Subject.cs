using System.Diagnostics.CodeAnalysis;

namespace SchoolWebApp.Models {
      public class Subject {
        public int Id { get; set; }
        [NotNull]
        public String Name { get; set; }
    }
}
