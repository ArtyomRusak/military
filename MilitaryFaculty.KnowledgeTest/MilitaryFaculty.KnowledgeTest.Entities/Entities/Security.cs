namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Security : Entity<int>
    {
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
    }
}
