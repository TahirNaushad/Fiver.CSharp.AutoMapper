using System.Collections.Generic;

namespace Fiver.CSharp.AutoMapper.Layer1
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public bool HasReleased { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
