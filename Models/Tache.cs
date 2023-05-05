namespace Tasks.Models
{
    class Tache
    {
        string title {get; set;} = "";
        string description { get; set; } = "";
        DateTime deadline { get; set; } = DateTime.Now;
        int userId { get; set; } = 0;

        public Tache(string title, string description, DateTime deadline, int userId)
        {
            this.title = title;
            this.description = description;
            this.deadline = deadline;
            this.userId = userId;
        }
    }
}