using AutoMapper;
using Fiver.CSharp.AutoMapper.Layer1;
using Fiver.CSharp.AutoMapper.Layer2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fiver.CSharp.AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupMappings();

            Console.WriteLine("Movie to MovieEntity");
            Layer1_To_Layer2();

            //Console.WriteLine("------------------");

            //Console.WriteLine("MovieEntity to Movie");
            //Layer2_To_Layer1();

            Console.ReadLine();
        }

        private static void SetupMappings()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Actor, ActorEntity>().ReverseMap();
                config.CreateMap<Movie, MovieEntity>().ReverseMap();
            });
        }

        private static void Layer1_To_Layer2()
        {
            var movie = new Movie
            {
                Id = 1,
                Title = "Goldfinger",
                ReleaseYear = 1964,
                HasReleased = true,
                Actors = new List<Actor>
                {
                    new Actor{ Id = 1, Name = "Sean Connery" },
                    new Actor { Id = 2, Name = "Money Penny" }
                }
            };

            var entity = Mapper.Map<Movie, MovieEntity>(movie);
            var json = JsonConvert.SerializeObject(entity, Formatting.Indented);
            Console.WriteLine(json);
        }

        private static void Layer2_To_Layer1()
        {
            var entity = new MovieEntity
            {
                Id = 1,
                Title = "Goldfinger",
                ReleaseYear = 1964,
                HasReleased = true,
                Actors = new List<ActorEntity>
                {
                    new ActorEntity{ Id = 1, Name = "Sean Connery" },
                    new ActorEntity { Id = 2, Name = "Money Penny" }
                }
            };

            var movie = Mapper.Map<MovieEntity, Movie>(entity);
            var json = JsonConvert.SerializeObject(movie, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
