namespace WorksManagerMini.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string WorkType { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; } = "Open";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public string? ProofImage { get; set; }
    }
}