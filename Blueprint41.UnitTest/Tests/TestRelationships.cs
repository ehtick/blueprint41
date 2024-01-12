﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Blueprint41.Core;
using Blueprint41.DatastoreTemplates;
using Blueprint41.Query;
using Blueprint41.UnitTest.DataStore;
using Blueprint41.UnitTest.Helper;
using Blueprint41.UnitTest.Mocks;

using Datastore.Manipulation;
using Datastore.Query;

using NUnit.Framework;
using NUnit.Framework.Internal;
using node = Datastore.Query.Node;

namespace Blueprint41.UnitTest.Tests
{
    [TestFixture]
    public class TestRelationships
    {
        #region Initialize Test Class

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            MockNeo4jPersistenceProvider persistenceProvider = new MockNeo4jPersistenceProvider(DatabaseConnectionSettings.URI, DatabaseConnectionSettings.USER_NAME, DatabaseConnectionSettings.PASSWORD);
            PersistenceProvider.CurrentPersistenceProvider = persistenceProvider;

            TearDown();
        }
        
        [SetUp]
        public void Setup()
        {
            // Run mock model every time because the FunctionalId is wiped out by cleanup and needs to be recreated!
            MockModel model = new MockModel()
            {
                LogToConsole = true
            };
            model.Execute(true);

            DatabaseUids = Uids.SetupDb();
        }

        [TearDown]
        public void TearDown()
        {
            using (Transaction.Begin())
            {
                string reset = "Match (n) detach delete n";
                Transaction.RunningTransaction.Run(reset);

                Transaction.Commit();
            }
            using (Transaction.Begin())
            {
                string clearSchema = "CALL apoc.schema.assert({},{},true) YIELD label, key RETURN *";
                Transaction.RunningTransaction.Run(clearSchema);
                Transaction.Commit();
            }
        }

        public Uids DatabaseUids;

        public record class Uids
        {
            public Uids(MovieUids movies, RatingUids ratings, PersonUids persons, CityUids cities, StreamingServiceUids streamingServices)
            {
                Movies = movies;
                Movies.Parent = this;

                Ratings = ratings;
                Ratings.Parent = this;

                Persons = persons;
                Persons.Parent = this;

                Cities = cities;
                Cities.Parent = this;

                StreamingServices = streamingServices;
                StreamingServices.Parent = this;
            }

            public MovieUids Movies;
            public RatingUids Ratings;
            public PersonUids Persons;
            public CityUids Cities;
            public StreamingServiceUids StreamingServices;

            public static Uids SetupDb()
            {
                MovieUids movies;
                RatingUids ratings;
                PersonUids persons;
                CityUids cities;
                StreamingServiceUids streamingServices;

                using (Transaction.Begin())
                {
                    #region Movies

                    Movie aliens = new Movie()
                    {
                        Title = "Aliens",
                    };
                    Movie dieHard = new Movie()
                    {
                        Title = "Die Hard",
                    };
                    Movie matrix = new Movie()
                    {
                        Title = "The Matrix",
                    };
                    Movie serenity = new Movie()
                    {
                        Title = "Serenity",
                    };
                    Movie terminator2 = new Movie()
                    {
                        Title = "Terminator 2: Judgment Day",
                    };
                    Movie theFifthElement = new Movie()
                    {
                        Title = "The Fifth Element",
                    };
                    Movie topGunMaverick = new Movie()
                    {
                        Title = "Top Gun: Maverick",
                    };

                    #endregion

                    #region Ratings

                    Rating g = new Rating()
                    {
                        Code = "G",
                        Name = "Rated G",
                        Description = "General audiences – All ages admitted.",
                    };
                    Rating pg = new Rating()
                    {
                        Code = "PG",
                        Name = "Rated PG",
                        Description = "Parental guidance suggested – Some material may not be suitable for children.",
                    };
                    Rating pg13 = new Rating()
                    {
                        Code = "PG-13",
                        Name = "Rated PG-13",
                        Description = "Parents strongly cautioned – Some material may be inappropriate for children under 13.",
                    };
                    Rating r = new Rating()
                    {
                        Code = "R",
                        Name = "Rated R",
                        Description = "Restricted – Under 17 requires accompanying parent or adult guardian.",
                    };
                    Rating nc17 = new Rating()
                    {
                        Code = "NC-17",
                        Name = "Rated NC-17",
                        Description = "Adults Only – No one 17 and under admitted.",
                    };

                    #endregion

                    #region Persons

                    Person alanTuring = new Person()
                    {
                        Name = "Alan Turing",
                    };
                    Person dennisRitchie = new Person()
                    {
                        Name = "Dennis Ritchie",
                    };
                    Person martinFowler = new Person()
                    {
                        Name = "Martin Fowler",
                    };
                    Person uncleBob = new Person()
                    {
                        Name = "Robert C. Martin",
                    };
                    Person adaLovelace = new Person()
                    {
                        Name = "Ada Lovelace",
                    };
                    Person linusTorvalds = new Person()
                    {
                        Name = "Linus Torvalds",
                    };
                    Person alanKay = new Person()
                    {
                        Name = "Alan Kay",
                    };
                    Person steveWozniak = new Person()
                    {
                        Name = "Steve Wozniak",
                    };
                    Person billGates = new Person()
                    {
                        Name = "Bill Gates",
                    };

                    #endregion

                    #region Cities

                    City london = new City()
                    {
                        Name = "London",
                        Country = "UK",
                    };
                    City littleWhinging = new City()
                    {
                        Name = "Little Whinging",
                        State = "Surrey",
                        Country = "UK",
                    };
                    City springfield = new City()
                    {
                        Name = "Springfield",
                        Country = "US",
                    };
                    City hillValley = new City()
                    {
                        Name = "Hill Valley",
                        State = "CA",
                        Country = "US",
                    };
                    City sunnydale = new City()
                    {
                        Name = "Sunnydale",
                        State = "CA",
                        Country = "US",
                    };
                    City quahog = new City()
                    {
                        Name = "Quahog",
                        State = "Rhode Island",
                        Country = "US",
                    };
                    City muncie = new City()
                    {
                        Name = "Muncie",
                        State = "Indiana",
                        Country = "US",
                    };
                    City metropolis = new City()
                    {
                        Name = "Metropolis",
                        Country = "US",
                    };

                    #endregion

                    #region Streaming Services

                    StreamingService netflix = new StreamingService()
                    {
                        Name = "Netflix",
                    };
                    StreamingService hulu = new StreamingService()
                    {
                        Name = "Hulu",
                    };
                    StreamingService peacock = new StreamingService()
                    {
                        Name = "Peacock",
                    };
                    StreamingService amazonPrimeVideo = new StreamingService()
                    {
                        Name = "Amazon Prime Video",
                    };
                    StreamingService hboMax = new StreamingService()
                    {
                        Name = "Max",
                    };
                    StreamingService disneyPlus = new StreamingService()
                    {
                        Name = "Disney+",
                    };
                    StreamingService historyVault = new StreamingService()
                    {
                        Name = "History Vault",
                    };

                    #endregion

                    Transaction.Commit();

                    return new Uids(
                        new MovieUids()
                        {
                            Aliens = aliens.Uid,
                            DieHard = dieHard.Uid,
                            Matrix = matrix.Uid,
                            Serenity = serenity.Uid,
                            Terminator2 = terminator2.Uid,
                            TheFifthElement = theFifthElement.Uid,
                            TopGunMaverick = topGunMaverick.Uid,
                        },
                        new RatingUids()
                        {
                            G = g.Uid,
                            PG = pg.Uid,
                            PG13 = pg13.Uid,
                            R = r.Uid,
                            NC17 = nc17.Uid,
                        },
                        new PersonUids()
                        {
                            AlanTuring = alanTuring.Uid,
                            DennisRitchie = dennisRitchie.Uid,
                            MartinFowler = martinFowler.Uid,
                            UncleBob = uncleBob.Uid,
                            AdaLovelace = adaLovelace.Uid,
                            LinusTorvalds = linusTorvalds.Uid,
                            AlanKay = alanKay.Uid,
                            SteveWozniak = steveWozniak.Uid,
                            BillGates = billGates.Uid,
                        },
                        new CityUids()
                        {
                            London = london.Uid,
                            LittleWhinging = littleWhinging.Uid,
                            Springfield = springfield.Uid,
                            HillValley = hillValley.Uid,
                            Sunnydale = sunnydale.Uid,
                            Quahog = quahog.Uid,
                            Muncie = muncie.Uid,
                            Metropolis = metropolis.Uid,
                        },
                        new StreamingServiceUids()
                        {
                            Netflix = netflix.Uid,
                            Hulu = hulu.Uid,
                            Peacock = peacock.Uid,
                            AmazonPrimeVideo = amazonPrimeVideo.Uid,
                            HboMax = hboMax.Uid,
                            DisneyPlus = disneyPlus.Uid,
                            HistoryVault = historyVault.Uid,
                        }
                    );
                }
            }
        }
        public record class MovieUids
        {
            public Uids Parent;

            public string Aliens;
            public string DieHard;
            public string Matrix;
            public string Serenity;
            public string Terminator2;
            public string TheFifthElement;
            public string TopGunMaverick;

            public Ratings Ratings => Threadsafe.LazyInit(ref _ratings, () => new Ratings(Parent));
            private Ratings _ratings = null;

            public (Movie movie, Rating rating, RatingComponent frighteningIntense, RatingComponent violenceGore, RatingComponent profanity, RatingComponent substances, RatingComponent sexAndNudity)[] Movies => new[]
            {
                (Movie.Load(Aliens),          Rating.Load(Ratings.Aliens.Rating)         , Ratings.Aliens.FrighteningIntense,          Ratings.Aliens.ViolenceGore,          Ratings.Aliens.Profanity,         Ratings.Aliens.Substances,          Ratings.Aliens.SexAndNudity),
                (Movie.Load(DieHard),         Rating.Load(Ratings.DieHard.Rating)        , Ratings.DieHard.FrighteningIntense,         Ratings.DieHard.ViolenceGore,         Ratings.DieHard.Profanity,        Ratings.DieHard.Substances,         Ratings.DieHard.SexAndNudity),
                (Movie.Load(Matrix),          Rating.Load(Ratings.Matrix.Rating)         , Ratings.Matrix.FrighteningIntense,          Ratings.Matrix.ViolenceGore,          Ratings.Matrix.Profanity,         Ratings.Matrix.Substances,          Ratings.Matrix.SexAndNudity),
                (Movie.Load(Serenity),        Rating.Load(Ratings.Serenity.Rating)       , Ratings.Serenity.FrighteningIntense,        Ratings.Serenity.ViolenceGore,        Ratings.Serenity.Profanity,       Ratings.Serenity.Substances,        Ratings.Serenity.SexAndNudity),
                (Movie.Load(Terminator2),     Rating.Load(Ratings.Terminator2.Rating)    , Ratings.Terminator2.FrighteningIntense,     Ratings.Terminator2.ViolenceGore,     Ratings.Terminator2.Profanity,    Ratings.Terminator2.Substances,     Ratings.Terminator2.SexAndNudity),
                (Movie.Load(TheFifthElement), Rating.Load(Ratings.TheFifthElement.Rating), Ratings.TheFifthElement.FrighteningIntense, Ratings.TheFifthElement.ViolenceGore, Ratings.TheFifthElement.Profanity,Ratings.TheFifthElement.Substances, Ratings.TheFifthElement.SexAndNudity),
                (Movie.Load(TopGunMaverick),  Rating.Load(Ratings.TopGunMaverick.Rating) , Ratings.TopGunMaverick.FrighteningIntense,  Ratings.TopGunMaverick.ViolenceGore,  Ratings.TopGunMaverick.Profanity, Ratings.TopGunMaverick.Substances,  Ratings.TopGunMaverick.SexAndNudity),
            };
        }
        public record class RatingUids
        {
            public Uids Parent;

            public string G;
            public string PG;
            public string PG13;
            public string R;
            public string NC17;
        }
        public record class PersonUids
        {
            public Uids Parent;

            public string AlanTuring;           // Inventor of the modern computer
            public string DennisRitchie;        // Unix developer & Teacher
            public string MartinFowler;         // Co creator of the Agile Manifesto
            public string UncleBob;             // Uncle Bob
            public string AdaLovelace;          // Inventor of the Ada language
            public string LinusTorvalds;        // Developer of the Linux kernel
            public string AlanKay;              // Smalltalk (first OO programming language)
            public string SteveWozniak;         // Inventor of the Apple computer
            public string BillGates;            // Programmed the most famous BASIC interpreter

            public Person[] Persons => new[]
            {
                Person.Load(AlanTuring),
                Person.Load(DennisRitchie),
                Person.Load(MartinFowler),
                Person.Load(UncleBob),
                Person.Load(AdaLovelace),
                Person.Load(LinusTorvalds),
                Person.Load(AlanKay),
                Person.Load(SteveWozniak),
                Person.Load(BillGates),
            };
        }
        public record class CityUids
        {
            public Uids Parent;

            public string London;
            public string LittleWhinging;
            public string Springfield;
            public string HillValley;
            public string Sunnydale;
            public string Quahog;
            public string Muncie;
            public string Metropolis;

            public static class AddressLines
            {
                public static class London
                {
                    // Sherlock Holmes - 221B Baker Street, London, UK
                    public static readonly string[] SherlockHolmes = { "221B Baker Street" };

                    // Hercule Poirot - Apt. 56B, Whitehaven Mansions, Sandhurst Square, London, UK
                    public static readonly string[] HerculePoirot = { "Apt. 56B Whitehaven Mansions", "Sandhurst Square" };
                }
                public static class LittleWhinging
                {
                    // Harry Potter - The cupboard under the Stairs, 4 Privet Drive, Little Whinging, Surrey
                    public static readonly string[] HarryPotter = { "The cupboard under the Stairs", "4 Privet Drive", "Little Whinging" };
                }
                public static class Springfield
                {
                    // the Simpsons - 742 Evergreen Terrace, Springfield
                    public static readonly string[] TheSimpsons = { "742 Evergreen Terrace" };
                }
                public static class HillValley
                {
                    // Emmett Brown (Back to the Future) - 1640 Riverside Drive, Hill Valley, California
                    public static readonly string[] EmmettBrown = { "1640 Riverside Drive" };
                }
                public static class Sunnydale
                {
                    // Buffy Summers (Buffy the Vampire Slayer) - 1630 Revello Drive, Sunnydale, CA
                    public static readonly string[] BuffySummers = { "1630 Revello Drive" };
                }
                public static class Quahog
                {
                    // Peter Griffin (Family Guy) - 31 Spooner Street, Quahog, Rhode Island
                    public static readonly string[] PeterGriffin = { "31 Spooner Street" };
                }
                public static class Muncie
                {
                    // Garfield - 711 Maple Street, Muncie, Indiana, USA
                    public static readonly string[] Garfield = { "711 Maple Street" };
                }
                public static class Metropolis
                {
                    // Clark Kent (Superman) - 344 Clinton St., Apt. 3B, Metropolis, USA (later 1938 Sullivan Lane, Metropolis)
                    public static readonly string[] ClarkKent_Earlier = { "Apt. 3B ", "344 Clinton St." };
                    public static readonly string[] ClarkKent_Later = { "1938 Sullivan Lane" };
                }
            }

            public (City city, string[] addressLines, string[] moveTo)[] Addresses => new[]
            {
                (City.Load(London),         AddressLines.London.SherlockHolmes,        null),
                (City.Load(London),         AddressLines.London.HerculePoirot,         null),
                (City.Load(LittleWhinging), AddressLines.LittleWhinging.HarryPotter,   null),
                (City.Load(Springfield),    AddressLines.Springfield.TheSimpsons,      null),
                (City.Load(HillValley),     AddressLines.HillValley.EmmettBrown,       null),
                (City.Load(Sunnydale),      AddressLines.Sunnydale.BuffySummers,       null),
                (City.Load(Quahog),         AddressLines.Quahog.PeterGriffin,          null),
                (City.Load(Muncie),         AddressLines.Muncie.Garfield,              null),
                (City.Load(Metropolis),     AddressLines.Metropolis.ClarkKent_Earlier, AddressLines.Metropolis.ClarkKent_Later)
            };
        }
        public record class StreamingServiceUids
        {
            public Uids Parent;

            public string Netflix;
            public string Hulu;
            public string Peacock;
            public string AmazonPrimeVideo;
            public string HboMax;
            public string DisneyPlus;
            public string HistoryVault;

            public static class Rates
            {
                public static readonly decimal Netflix          =  6.99m;
                public static readonly decimal Hulu             =  7.99m;
                public static readonly decimal HuluAdFree       = 17.99m;
                public static readonly decimal Peacock          =  5.99m;
                public static readonly decimal AmazonPrimeVideo =  8.99m;
                public static readonly decimal HboMax           =  9.99m;
                public static readonly decimal DisneyPlus       =  7.99m;
                public static readonly decimal HistoryVault     =  4.99m;
            }

            public (StreamingService streamingService, decimal monthlyFee, decimal? monthlyFeeChanged)[] StreamingServices => new[]
            {
                (StreamingService.Load(Netflix),          Rates.Netflix,          default(decimal?)),
                (StreamingService.Load(Hulu),             Rates.Hulu,             Rates.HuluAdFree),
                (StreamingService.Load(Peacock),          Rates.Peacock,          default(decimal?)),
                (StreamingService.Load(AmazonPrimeVideo), Rates.AmazonPrimeVideo, default(decimal?)),
                (StreamingService.Load(HboMax),           Rates.HboMax,           default(decimal?)),
                (StreamingService.Load(DisneyPlus),       Rates.DisneyPlus,       default(decimal?)),
                (StreamingService.Load(HistoryVault),     Rates.HistoryVault,     default(decimal?)),
            };
        }

        public record class Ratings
        {
            public Ratings(Uids parent)
            {
                Aliens = new AliensRatings(parent);
                DieHard = new DieHardRatings(parent);
                Matrix = new MatrixRatings(parent);
                Serenity = new SerenityRatings(parent);
                Terminator2 = new Terminator2Ratings(parent);
                TheFifthElement = new TheFifthElementRatings(parent);
                TopGunMaverick = new TopGunMaverickRatings(parent);
            }

            public AliensRatings Aliens;
            public DieHardRatings DieHard;
            public MatrixRatings Matrix;
            public SerenityRatings Serenity;
            public Terminator2Ratings Terminator2;
            public TheFifthElementRatings TheFifthElement;
            public TopGunMaverickRatings TopGunMaverick;
        }
        public record class AliensRatings(Uids Parent)
        {
            public string Rating => Parent.Ratings.R;
            public RatingComponent FrighteningIntense = RatingComponent.Severe;
            public RatingComponent ViolenceGore = RatingComponent.Moderate;
            public RatingComponent Profanity = RatingComponent.Moderate;
            public RatingComponent Substances = RatingComponent.Mild;
            public RatingComponent SexAndNudity = RatingComponent.None;
        }
        public record class DieHardRatings(Uids Parent)
        {
            public string Rating => Parent.Ratings.R;
            public RatingComponent FrighteningIntense = RatingComponent.Moderate;
            public RatingComponent ViolenceGore = RatingComponent.Severe;
            public RatingComponent Profanity = RatingComponent.Severe;
            public RatingComponent Substances = RatingComponent.Moderate;
            public RatingComponent SexAndNudity = RatingComponent.Mild;
        }
        public record class MatrixRatings(Uids Parent)
        {
            public string Rating => Parent.Ratings.R;
            public RatingComponent FrighteningIntense = RatingComponent.None;
            public RatingComponent ViolenceGore = RatingComponent.Moderate;
            public RatingComponent Profanity = RatingComponent.Moderate;
            public RatingComponent Substances = RatingComponent.Mild;
            public RatingComponent SexAndNudity = RatingComponent.Mild;
        }
        public record class SerenityRatings(Uids Parent)
        {
            public string Rating => Parent.Ratings.PG13;
            public RatingComponent FrighteningIntense = RatingComponent.Moderate;
            public RatingComponent ViolenceGore = RatingComponent.Moderate;
            public RatingComponent Profanity = RatingComponent.Mild;
            public RatingComponent Substances = RatingComponent.Mild;
            public RatingComponent SexAndNudity = RatingComponent.Mild;
        }
        public record class Terminator2Ratings(Uids Parent)
        {
            public string Rating => Parent.Ratings.R;
            public RatingComponent FrighteningIntense = RatingComponent.Moderate;
            public RatingComponent ViolenceGore = RatingComponent.Severe;
            public RatingComponent Profanity = RatingComponent.Moderate;
            public RatingComponent Substances = RatingComponent.Mild;
            public RatingComponent SexAndNudity = RatingComponent.Mild;
        }
        public record class TheFifthElementRatings(Uids Parent)
        {
            public string Rating => Parent.Ratings.PG13;
            public RatingComponent FrighteningIntense = RatingComponent.Mild;
            public RatingComponent ViolenceGore = RatingComponent.Mild;
            public RatingComponent Profanity = RatingComponent.Mild;
            public RatingComponent Substances = RatingComponent.Mild;
            public RatingComponent SexAndNudity = RatingComponent.Moderate;
        }
        public record class TopGunMaverickRatings(Uids Parent)
        {
            public string Rating => Parent.Ratings.PG13;
            public RatingComponent FrighteningIntense = RatingComponent.Moderate;
            public RatingComponent ViolenceGore = RatingComponent.Mild;
            public RatingComponent Profanity = RatingComponent.Moderate;
            public RatingComponent Substances = RatingComponent.Mild;
            public RatingComponent SexAndNudity = RatingComponent.None;
        }

        #endregion

        [Test]
        public void TimeDependentLookupSetLegacy()
        {
            #region Set Same City

            List<TestScenario> scenariosAdd = TestScenario.Get(TestAction.AddSame);

            foreach (TestScenario scenario in scenariosAdd)
            {
                Debug.WriteLine($"Set City: {scenario}");

                using (Transaction.Begin())
                {
                    var person = Person.Load(DatabaseUids.Persons.LinusTorvalds);
                    var city = City.Load(DatabaseUids.Cities.Metropolis);

                    CleanupRelations(PERSON_LIVES_IN.Relationship);

                    foreach (var relation in scenario.Initial)
                    {
                        WriteRelation(person, PERSON_LIVES_IN.Relationship, city, relation.from, relation.till);
                    }

                    person.SetCity(city, scenario.Moment);

                    Transaction.Flush();

                    scenario.SetActual(ReadRelations(person, PERSON_LIVES_IN.Relationship, city));

                    Transaction.Commit();
                }
            }

            scenariosAdd.AssertSuccess();

            #endregion

            #region Set NULL

            List<TestScenario> scenariosRemove = TestScenario.Get(TestAction.Remove);

            foreach (TestScenario scenario in scenariosRemove)
            {
                Debug.WriteLine($"Set NULL: {scenario}");

                using (Transaction.Begin())
                {
                    var person = Person.Load(DatabaseUids.Persons.LinusTorvalds);
                    var city = City.Load(DatabaseUids.Cities.Metropolis);

                    CleanupRelations(PERSON_LIVES_IN.Relationship);

                    foreach (var relation in scenario.Initial)
                    {
                        WriteRelation(person, PERSON_LIVES_IN.Relationship, city, relation.from, relation.till);
                    }

                    person.SetCity(null, scenario.Moment);

                    Transaction.Flush();

                    scenario.SetActual(ReadRelations(person, PERSON_LIVES_IN.Relationship, city));

                    Transaction.Commit();
                }
            }

            scenariosRemove.AssertSuccess();

            #endregion
        }

        [Test]
        public void TimeDependentCollectionAddAndRemoveLegacy()
        {
            #region Add Same City

            List<TestScenario> scenariosAdd = TestScenario.Get(TestAction.AddSame);

            foreach (TestScenario scenario in scenariosAdd)
            {
                Debug.WriteLine($"Add Streaming Service: {scenario}");

                using (Transaction.Begin())
                {
                    var person = Person.Load(DatabaseUids.Persons.LinusTorvalds);
                    var netflix = StreamingService.Load(DatabaseUids.StreamingServices.Netflix);

                    var initial = GetState(scenario.Initial, netflix);
                    var expected = GetState(scenario.Expected, netflix);

                    CleanupRelations(SUBSCRIBED_TO_STREAMING_SERVICE.Relationship);

                    foreach (var state in initial)
                    {
                        foreach (var relation in state.relations)
                            WriteRelation(person, SUBSCRIBED_TO_STREAMING_SERVICE.Relationship, state.target, relation.from, relation.till);
                    }

                    person.StreamingServiceSubscriptions.Add(netflix, scenario.Moment);

                    Transaction.Flush();

                    foreach (var state in expected.Skip(1))
                    {
                        var actual = ReadRelations(person, SUBSCRIBED_TO_STREAMING_SERVICE.Relationship, state.target);
                        var expectedAsciiArt = TestScenario.DrawAsciiArtState(state.relations);
                        var actualAsciiArt = TestScenario.DrawAsciiArtState(actual);
                        Assert.AreEqual(expectedAsciiArt, actualAsciiArt);
                    }
                    scenario.SetActual(ReadRelations(person, SUBSCRIBED_TO_STREAMING_SERVICE.Relationship, netflix));

                    Transaction.Commit();
                }
            }

            scenariosAdd.AssertSuccess();

            #endregion

            #region Remove Same City

            List<TestScenario> scenariosRemove = TestScenario.Get(TestAction.Remove);

            foreach (TestScenario scenario in scenariosRemove)
            {
                Debug.WriteLine($"Remove Streaming Service: {scenario}");

                using (Transaction.Begin())
                {
                    var person = Person.Load(DatabaseUids.Persons.LinusTorvalds);
                    var netflix = StreamingService.Load(DatabaseUids.StreamingServices.Netflix);

                    var initial = GetState(scenario.Initial, netflix);
                    var expected = GetState(scenario.Expected, netflix);

                    CleanupRelations(SUBSCRIBED_TO_STREAMING_SERVICE.Relationship);

                    foreach (var state in initial)
                    {
                        foreach (var relation in state.relations)
                            WriteRelation(person, SUBSCRIBED_TO_STREAMING_SERVICE.Relationship, state.target, relation.from, relation.till);
                    }

                    person.StreamingServiceSubscriptions.Remove(netflix, scenario.Moment);

                    Transaction.Flush();

                    foreach (var state in expected.Skip(1))
                    {
                        var actual = ReadRelations(person, SUBSCRIBED_TO_STREAMING_SERVICE.Relationship, state.target);
                        var expectedAsciiArt = TestScenario.DrawAsciiArtState(state.relations);
                        var actualAsciiArt = TestScenario.DrawAsciiArtState(actual);
                        Assert.AreEqual(expectedAsciiArt, actualAsciiArt);
                    }
                    scenario.SetActual(ReadRelations(person, SUBSCRIBED_TO_STREAMING_SERVICE.Relationship, netflix));

                    Transaction.Commit();
                }
            }

            scenariosRemove.AssertSuccess();

            #endregion


            List<(List<(DateTime from, DateTime till)> relations, StreamingService target)> GetState(List<(DateTime from, DateTime till)> scenario, StreamingService item)
            {
                var amazon  = StreamingService.Load(DatabaseUids.StreamingServices.AmazonPrimeVideo);
                var hboMax  = StreamingService.Load(DatabaseUids.StreamingServices.HboMax);
                var peacock = StreamingService.Load(DatabaseUids.StreamingServices.Peacock);
                var hulu    = StreamingService.Load(DatabaseUids.StreamingServices.Hulu);
                var history = StreamingService.Load(DatabaseUids.StreamingServices.HistoryVault);

                return new List<(List<(DateTime, DateTime)> initial, StreamingService)>()
                {
                    (scenario, item),
                    (TestScenario.RelationsFromMask(0b0010), amazon),
                    (TestScenario.RelationsFromMask(0b0101), hboMax),
                    (TestScenario.RelationsFromMask(0b1010), peacock),
                    (TestScenario.RelationsFromMask(0b1001), hulu),
                    (TestScenario.RelationsFromMask(0b1111), history),
                };
            }
        }


        #region Helper Methods

        private void CleanupRelations(Relationship relationship)
        {
            string cypher = $"""
                MATCH (:{relationship.InEntity.Label.Name})-[r:{relationship.Neo4JRelationshipType}]->(:{relationship.OutEntity.Label.Name})
                DELETE r
                """;

            Transaction.RunningTransaction.Run(cypher);
        }

        private void WriteRelation(OGM @in, Relationship relationship, OGM @out, DateTime? from, DateTime? till)
        {
            string cypher = $"""
                MATCH (in:{relationship.InEntity.Label.Name}), (out:{relationship.OutEntity.Label.Name})
                WHERE in.{@in.GetEntity().Key.Name} = $in AND out.{@out.GetEntity().Key.Name} = $out
                CREATE (in)-[r:{relationship.Neo4JRelationshipType}]->(out)
                SET r.CreationDate = $now,
                    r.StartDate = $from,
                    r.EndDate = $till
                """;

            var parameters = new Dictionary<string, object>()
            {
                { "in", @in.GetKey() },
                { "out", @out.GetKey() },
                { "now", PersistenceProvider.CurrentPersistenceProvider.ConvertToStoredType(DateTime.UtcNow) },
                { "from", PersistenceProvider.CurrentPersistenceProvider.ConvertToStoredType(from) },
                { "till", PersistenceProvider.CurrentPersistenceProvider.ConvertToStoredType(till) },
            };

            Transaction.RunningTransaction.Run(cypher, parameters);
        }

        private List<(DateTime from, DateTime till)> ReadRelations(OGM @in, Relationship relationship, OGM @out)
        {
            string cypher = $"""
                MATCH (in:{relationship.InEntity.Label.Name})-[r:{relationship.Neo4JRelationshipType}]->(out:{relationship.OutEntity.Label.Name})
                WHERE in.{@in.GetEntity().Key.Name} = $in AND out.{@out.GetEntity().Key.Name} = $out
                RETURN r.StartDate AS `From`, r.EndDate AS `Till`
                """;

            var parameters = new Dictionary<string, object>()
            {
                { "in", @in.GetKey() },
                { "out", @out.GetKey() },
            };

            RawResult result = Transaction.RunningTransaction.Run(cypher, parameters);

            return result.Select(delegate(RawRecord record)
            {
                DateTime from = Conversion<long, DateTime>.Convert(record.Values["From"].As<long>());
                DateTime till = Conversion<long, DateTime>.Convert(record.Values["Till"].As<long>());

                return (from, till);
            }).ToList();
        }
        private List<(DateTime from, DateTime till, Dictionary<string, object> properties)> ReadRelationsWithProperties(OGM @in, Relationship relationship, OGM @out)
        {
            string cypher = $"""
                MATCH (in:{relationship.InEntity.Label.Name})-[r:{relationship.Neo4JRelationshipType}]->(out:{relationship.OutEntity.Label.Name})
                WHERE in.{@in.GetEntity().Key.Name} = $in AND out.{@out.GetEntity().Key.Name} = $out
                RETURN r.StartDate AS `From`, r.EndDate AS `Till`, apoc.map.removeKeys(r, ['StartDate','EndDate','CreationDate']) AS Properties
                """;

            var parameters = new Dictionary<string, object>()
            {
                { "in", @in.GetKey() },
                { "out", @out.GetKey() },
            };

            using (Transaction.Begin())
            {
                RawResult result = Transaction.RunningTransaction.Run(cypher, parameters);

                return result.Select(delegate (RawRecord record)
                {
                    DateTime from = Conversion<long, DateTime>.Convert(record.Values["From"].As<long>());
                    DateTime till = Conversion<long, DateTime>.Convert(record.Values["Till"].As<long>());
                    Dictionary<string, object> properties = record.Values["Properties"].As<Dictionary<string, object>>();

                    return (from, till, properties);
                }).ToList();
            }
        }

        #endregion
    }
}

#region Sample Interface

//// Get all EATS_AT relations for the given person
//List<PERSON_EATS_AT> all = person.RestaurantRelations();
//// And set their 'Weight' & 'LastModifiedOn' properties
//all.Assign(Score: "Good", CreationDate: DateTime.UtcNow);

//// Get a sub-set of EATS_AT relations for the given person
//List<PERSON_EATS_AT> subset = person.RestaurantsWhere(alias => alias.Restaurant(restaurant) & alias.Score != "Bad");
//// And use LINQ to query restaurants
//IEnumerable<Restaurant> restaurants = subset.Select(rel => rel.Restaurant);

////// Get EATS_AT relations based on a JSON notated expression
//List<PERSON_EATS_AT> relations = PERSON_EATS_AT.Where(InNode: person, OutNode: restaurant);

//// Get EATS_AT relations based on a Bp41 notated expression
//List<PERSON_EATS_AT> relations2 = PERSON_EATS_AT.Where(alias => alias.Restaurants(restaurants) & alias.Person(person) & alias.Score != "Bad");

//// Get EATS_AT relations based on Bp41 notated expression, and set their 'Weight' property
//PERSON_EATS_AT.Where(alias => alias.Restaurants(restaurants)).Assign(Score: "Good");

//// Get a sub-set of EATS_AT relations for the given person, and set their 'Weight' property
//person.RestaurantsWhere(alias => alias.Score != "Bad").Assign(Score: "Good");

//// Lookup: Query LIVES_IN relation for the city OR null, depending on the condition
////         And potentially assign new values
//person.CityIf(alias => alias.Street == "San Nicolas Street" & alias.HouseNr == 8)?.Assign(HouseNr: 6);

//// Set city 
//person.SetCity(city, CreationDate: DateTime.UtcNow, Street: "San Nicolas Street", HouseNr: 6);

//// Add restaurant
//person.AddRestaurant(restaurant, CreationDate: DateTime.UtcNow, Score: "Good");

#endregion
