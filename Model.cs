using System.Data.Entity;
using System.Linq;

namespace Millionaire
{
    public class Model : DbContext
    {
        public Model() : base("DBConnection") { }
        public DbSet<Question> questions { get; set; }
        public DbSet<Winners> winners { get; set; }
        public Question GetQuestionByTitle(string title)
        {
            return questions.Where(x => x.Title == title).Single();
        }
    }
}
