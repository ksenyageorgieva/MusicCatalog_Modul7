namespace Ksenya_Modul7.Models

{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age {  get; set; }

        // Колекция от песни
        public required ICollection<Song> Songs { get; set; }
    }
}
