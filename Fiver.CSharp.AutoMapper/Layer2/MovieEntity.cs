using System.Collections.Generic;

namespace Fiver.CSharp.AutoMapper.Layer2
{
    public class MovieEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public bool HasReleased { get; set; }
        public List<ActorEntity> Actors { get; set; }
    }
}
