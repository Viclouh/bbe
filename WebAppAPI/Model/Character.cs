namespace WebAppAPI.Model
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Status}\n{Species}";
        }
    }
}
