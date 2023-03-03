namespace Teackinggg.Models
{
    public class Issue
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Descriptioni { get; set; }
        public IssueType Isu { get; set; }
        public Priority Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public enum IssueType
    {
        Feature,
        Bug,
        Documentation
    }
}
