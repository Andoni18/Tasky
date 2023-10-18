namespace Tasky.Models
{
    public class TaskModels
    {
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
