namespace EntityModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // 'income' or 'expense'
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
