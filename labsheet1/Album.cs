using System;

namespace labsheet1
{
    public class Album
    {
        public string Name { get; set; }
        public int Sales { get; set; }
        public DateTime ReleaseDate { get; set; }

        public override string ToString()
        {
            return $"{Name}\n {Sales}\n{ReleaseDate.ToShortDateString()}";
        }
    }
}