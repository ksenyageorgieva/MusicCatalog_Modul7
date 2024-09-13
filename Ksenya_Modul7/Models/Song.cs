namespace Ksenya_Modul7.Models
{
    public class Song
    {
     public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }

        // Външен ключ към Person
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public Song(Person person)
        {
            Person = person ?? throw new ArgumentNullException(nameof(person));
        }
    }
}
