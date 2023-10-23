namespace WebAppAPI.Model
{
    public class Characters
    {
        public List<Character> Results { get; set; }

        public Characters(List<Character> results)
        {
            Results = results;
        }
    }
}
