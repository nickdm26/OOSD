using DogSelector.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector.Models
{
    public class MakeDogDatabase
    {

        public List<Dog> makeDatabase()
        {
            List<Dog> newDatabase = new List<Dog>();

            Dog afghanHound = new Dog();
            afghanHound.BreedName = "afghanHound";
            afghanHound.DisplayName = "Afghan Hound";
            afghanHound.ActivityLevel = Enums.EScale.High;
            afghanHound.Coatlength = Enums.ELength.Long;
            afghanHound.Drools = false;
            afghanHound.GoodWithChildren = false;
            afghanHound.GroomingLevel = Enums.EScale.High;
            afghanHound.IntelligenceLevel = Enums.EScale.Low;
            afghanHound.SheddingLevel = Enums.EScale.High;
            afghanHound.Size = Enums.ESize.Large;
            afghanHound.ImageName = "AfghanHound.jpg";
            newDatabase.Add(afghanHound);


            Dog bassetHound = new Dog();
            bassetHound.BreedName = "BassetHound";
            bassetHound.DisplayName = "Basset Hound";
            bassetHound.ActivityLevel = Enums.EScale.Medium;
            bassetHound.Coatlength = Enums.ELength.Short;
            bassetHound.Drools = true;
            bassetHound.GoodWithChildren = true;
            bassetHound.GroomingLevel = Enums.EScale.Low;
            bassetHound.IntelligenceLevel = Enums.EScale.Medium;
            bassetHound.SheddingLevel = Enums.EScale.Low;
            bassetHound.Size = Enums.ESize.Medium;
            bassetHound.ImageName = "BassetHound.jpg";
            newDatabase.Add(bassetHound);

            Dog beagle = new Dog()
            {
                BreedName = "Beagle",
                DisplayName = "Beagle",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.Medium,
                IntelligenceLevel = Enums.EScale.Medium,
                SheddingLevel = Enums.EScale.Low,
                Size = Enums.ESize.Medium,
                ImageName = "Beagle.jpg"
            };
            newDatabase.Add(beagle);

            Dog bichonFrise = new Dog()
            {
                BreedName = "BichonFrise",
                DisplayName = "Bichon Frise",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.High,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.Low,
                Size = Enums.ESize.Small,
                ImageName = "Bichonfrise.jpg"
            };
            newDatabase.Add(bichonFrise);



            Dog borzoi = new Dog()
            {
                BreedName = "Borzoi",
                DisplayName = "Borzoi",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Long,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = Enums.EScale.High,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.High,
                Size = Enums.ESize.Large,
                ImageName = "Borzoi.jpg"
            };
            newDatabase.Add(borzoi);

            Dog bulldog = new Dog()
            {
                BreedName = "Bulldog",
                DisplayName = "Bull Dog",
                ActivityLevel = Enums.EScale.Medium,
                Coatlength = Enums.ELength.Short,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = Enums.EScale.Low,
                IntelligenceLevel = Enums.EScale.Medium,
                SheddingLevel = Enums.EScale.Low,
                Size = Enums.ESize.Medium,
                ImageName = "Bulldog.jpg"
            };
            newDatabase.Add(bulldog);


            Dog cav = new Dog()
            {
                BreedName = "CavalierKingCharlesSpaniel",
                DisplayName = "Cavalier King Charles Spaniel",
                ActivityLevel = Enums.EScale.Medium,
                Coatlength = Enums.ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.High,
                IntelligenceLevel = Enums.EScale.Medium,
                SheddingLevel = Enums.EScale.Medium,
                Size = Enums.ESize.Small,
                ImageName = "CavalierKingCharlesSpaniel.jpg"
            };
            newDatabase.Add(cav);


            Dog chowchow = new Dog()
            {
                BreedName = "Chowchow",
                DisplayName = "Chow Chow",
                ActivityLevel = Enums.EScale.Medium,
                Coatlength = Enums.ELength.Long,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = Enums.EScale.High,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.High,
                Size = Enums.ESize.Large,
                ImageName = "Chowchow.jpg"
            };
            newDatabase.Add(chowchow);

            Dog dalmation = new Dog()
            {
                BreedName = "Dalmation",
                DisplayName = "Dalmation",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Short,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = Enums.EScale.Medium,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.Low,
                Size = Enums.ESize.Large,
                ImageName = "Dalmation.jpg"
            };
            newDatabase.Add(dalmation);

            Dog goldenRetriever = new Dog()
            {
                BreedName = "GoldenRetriever",
                DisplayName = "Golden Retriever",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.Medium,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.High,
                Size = Enums.ESize.Large,
                ImageName = "GoldenRetriever.jpg"
            };
            newDatabase.Add(goldenRetriever);

            Dog maltese = new Dog()
            {
                BreedName = "Maltese",
                DisplayName = "Maltese",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.High,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.High,
                Size = Enums.ESize.Miniature,
                ImageName = "Maltese.jpg"
            };
            newDatabase.Add(maltese);

            Dog newfoundland = new Dog()
            {
                BreedName = "Newfoundland",
                DisplayName = "Newfoundland",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.Medium,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.High,
                Size = Enums.ESize.Giant,
                ImageName = "newfoundland.jpg"
            };
            newDatabase.Add(newfoundland);

            Dog oldEnglishSheepdog = new Dog()
            {
                BreedName = "OldEnglishSheepdog",
                DisplayName = "Old English Sheepdog",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.High,
                IntelligenceLevel = Enums.EScale.Medium,
                SheddingLevel = Enums.EScale.High,
                Size = Enums.ESize.Giant,
                ImageName = "OldEnglishSheepdog.jpg"
            };
            newDatabase.Add(oldEnglishSheepdog);

            Dog pug = new Dog()
            {
                BreedName = "Pug",
                DisplayName = "Pug",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.Low,
                IntelligenceLevel = Enums.EScale.Low,
                SheddingLevel = Enums.EScale.Low,
                Size = Enums.ESize.Miniature,
                ImageName = "Pug.jpg"
            };
            newDatabase.Add(pug);


            Dog westHighlandWhiteTerrier = new Dog()
            {
                BreedName = "WestHighlandWhiteTerrier",
                DisplayName = "West Highland White Terrier",
                ActivityLevel = Enums.EScale.High,
                Coatlength = Enums.ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Enums.EScale.Medium,
                IntelligenceLevel = Enums.EScale.High,
                SheddingLevel = Enums.EScale.Medium,
                Size = Enums.ESize.Small,
                ImageName = "WestHighlandWhiteTerrier.jpg"
            };
            newDatabase.Add(westHighlandWhiteTerrier);

            return newDatabase;
        }
    }
}