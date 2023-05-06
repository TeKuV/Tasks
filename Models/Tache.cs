namespace Tasks.Models
{
    class Tache
    {
        string title;
        public string Title { get=> title; set=> title = value; }

        string description { get; set; } = "";
        public string Description { get => description; set => description = value; }

        DateTime deadline = DateTime.Now;
        public DateTime Deadline { get => deadline; set => deadline = value; }

        int userId;
        public int UserId { get => userId; set => userId = value; }

        public Tache(string title, string description, DateTime deadline, User user)
        {
            this.title = title;
            this.description = description;
            this.deadline = deadline;
            this.userId = user.Id;
        }

        public static Tache Create(string title, string description, DateTime deadline, User user)
        {
            // Insert a new Task in the database
            // Code....

            return new Tache(title, description, deadline, user);
        }
    }
}