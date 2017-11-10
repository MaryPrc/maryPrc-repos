using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AlintaTest
{
    public class Program
    {
        public static HttpClient Client { get; set; } = new HttpClient();

        public static MoviesLibrary MyMovies { get; set; } = new MoviesLibrary();

        static void Main(string[] args)
        {
            RunAsync().Wait();
            List<Actor> actorsList = createActorsList();

            if (actorsList != null && actorsList.Count>0)
            {
                foreach (Actor actorItem in actorsList)
                {
                    Console.WriteLine("\n" + actorItem.Name);
                    actorItem.ActorsRoles.ForEach(r => Console.WriteLine("\t" + r.RoleName));
                }
            }
            Console.ReadLine();
        }

        public static List<Actor> createActorsList()
        {

            List<Actor> actorsList = new List<Actor>();
            int index = 0;
            try
            {
                foreach (Movie movie in MyMovies.Movies)
                {
                    foreach (Role role in movie.Roles)
                    {
                        role.MovieName = movie.MovieName;
                        index = actorsList.FindIndex(actor => actor.Name == role.ActorName);
                        if (index < 0)
                        {
                            Actor actorItem = new Actor();

                            actorItem.Name = role.ActorName;
                            actorItem.ActorsRoles.Add(role);
                            actorsList.Add(actorItem);
                        }
                        else
                        {
                            actorsList[index].ActorsRoles.Add(role);
                        }

                    }
                }

                return actorsList;
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        

        static async Task RunAsync()
        {
            Client.BaseAddress = new Uri("https://alintacodingtest.azurewebsites.net/api/Movies");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            try
            {
                await MyMovies.GetMoviesAsync(Client,Client.BaseAddress.ToString());   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
