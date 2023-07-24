namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntity
    {

        public Skill(string description)
        {
            this.Description = description;
            this.CreatedAt = DateTime.Now;
        }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}