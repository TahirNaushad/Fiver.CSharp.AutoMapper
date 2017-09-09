using System.Linq;

namespace Fiver.CSharp.AutoMapper.Layer1
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Initials => Name.Split(' ')
                                      .Select(n => n.First().ToString())
                                      .Aggregate((acc, next) => acc + next);
    }
}
