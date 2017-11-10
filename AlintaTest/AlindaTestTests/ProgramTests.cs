using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlintaTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlintaTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void createActorsListTest()
        {
             //MoviesLibrary myMovies = new MoviesLibrary();
            AlintaTest.Program.MyMovies.Movies = new List<Movie>
            {
                new Movie() {MovieName="Beverly Hills Cop" },
                new Movie() {MovieName="Stand By Me" },
            };

            AlintaTest.Program.MyMovies.Movies[0].Roles = new List<Role>
            {
                new Role(){RoleName="Axel Foley",ActorName="Eddie Murphy" },
                new Role(){RoleName="Billy Rosewood",ActorName="Judge Reinhold" },
                new Role(){RoleName="Sgt. Taggart",ActorName="John Ashton" },
                new Role(){RoleName="Jenny Summers",ActorName="Lisa Eilbacher" },
            };

            AlintaTest.Program.MyMovies.Movies[1].Roles = new List<Role>
            {
                new Role(){RoleName="Gorgie Lachance",ActorName="Wil Wheaton" },
                new Role(){RoleName="Chris Chambers",ActorName="River Phoenix" },
                new Role(){RoleName="Teddy Duchamp",ActorName="Corey Feldman" },
                new Role(){RoleName="Ace Merrill",ActorName="Keifer Sutherland" },
            };

            //myMovies.Movies[2].MovieName = "Star Trek";
            int expectedActors = 8;
            List<Actor> actorsList = AlintaTest.Program.createActorsList();

            Assert.AreEqual(expectedActors, actorsList.Count);

        }

        [TestMethod()]
        public void createActorsListTest2()
        {
            //MoviesLibrary myMovies = new MoviesLibrary();
            AlintaTest.Program.MyMovies.Movies = new List<Movie>
            {
                new Movie() {MovieName="Beverly Hills Cop" },
                new Movie() {MovieName="Stand By Me" },
                new Movie() {MovieName="Star Trek" },
            };

            AlintaTest.Program.MyMovies.Movies[0].Roles = new List<Role>
            {
                new Role(){RoleName="Axel Foley",ActorName="Eddie Murphy" },
                new Role(){RoleName="Billy Rosewood",ActorName="Judge Reinhold" },
                new Role(){RoleName="Sgt. Taggart",ActorName="John Ashton" },
                new Role(){RoleName="Jenny Summers",ActorName="Lisa Eilbacher" },
            };

            AlintaTest.Program.MyMovies.Movies[1].Roles = new List<Role>
            {
                new Role(){RoleName="Gorgie Lachance",ActorName="Wil Wheaton" },
                new Role(){RoleName="Chris Chambers",ActorName="River Phoenix" },
                new Role(){RoleName="Teddy Duchamp",ActorName="Corey Feldman" },
                new Role(){RoleName="Ace Merrill",ActorName="Keifer Sutherland" },
            };

            AlintaTest.Program.MyMovies.Movies[2].Roles = new List<Role>
            {
                new Role(){RoleName="Romulan",ActorName="Wil Wheaton" },
                new Role(){RoleName="Kirk",ActorName="Chris Pine" },
                new Role(){RoleName="Nero",ActorName="Eric Bana" },
                new Role(){RoleName="Spock",ActorName="Leonard Nimoy" },
                new Role(){RoleName="Scotty",ActorName="Simon Pegg" },
                new Role(){RoleName="Amanda Grayson",ActorName="Winona Ryder" },
            };

            int expectedActors = 13;
            List<Actor> actorsList = AlintaTest.Program.createActorsList();

            Assert.AreEqual(expectedActors, actorsList.Count);
            //Will weaton has 2 roles
            Assert.AreEqual(2, actorsList[4].ActorsRoles.Count);

        }

        [TestMethod()]
        public void createActorsListTest3()
        {
            AlintaTest.Program.MyMovies.Movies = null;
            List<Actor> actorsList = AlintaTest.Program.createActorsList();

            Assert.AreEqual(null, actorsList);

        }

        [TestMethod()]
        public void createActorsListTest4()
        {
            AlintaTest.Program.MyMovies.Movies = new List<Movie>();
            List<Actor> actorsList = AlintaTest.Program.createActorsList();

            Assert.AreEqual(0, actorsList.Count);

        }
    }
}