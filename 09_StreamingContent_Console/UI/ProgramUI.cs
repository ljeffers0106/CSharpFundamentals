﻿using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
  public class ProgramUI
    {
        // created for user interface
        // created streaming repository instance - window to access all functionality


        private readonly IConsole _console;
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContentList();
            RunMenu();

        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
            _console.Clear();
            _console.WriteLine(
                "Enter the number of the option you'd like to select: \n" +
                "1. Show all streaming content \n" +
                "2. Find streaming content by title \n" +
                "3. Add new streaming content \n" +
                "4. Remove streaming content \n" +
                "5. Exit");
            string userInput = _console.ReadLine();
            switch(userInput)
            {
                case "1":
                        //show all
                    ShowAllContent();
                    break;
                case "2":
                        // find by title
                    ShowContentByTitle();
                    break;
                case "3":
                    // Add new
                    CreateNewContent(); 
                    break;
                case "4":
                        //remove
                    RemoveContentFromList();
                    break;
                case "5":
                    //exit
                    continueToRun = false;
                    break;
                default:
                    _console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                        "Press any key to continue...");
                    _console.ReadKey();

                    break;
                }
               
            }
        }
        private void CreateNewContent()
        {
            _console.Clear();
            StreamingContent content = new StreamingContent();
            // title
            _console.WriteLine("Please enter the title of the content: ");
            content.Title = _console.ReadLine();

            // description
            _console.WriteLine("Please enter the description: ");
            content.Description = _console.ReadLine();

            // MRating
            _console.WriteLine("Select a Maturity Reading: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG_13 \n" +
                "4) R \n" +
                "5) NC_17 \n" +
                "6) TV_MA");
            string maturityString = _console.ReadLine();
            switch (maturityString)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;

                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;

                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;

                case "6":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }

            // Star Rating
            _console.WriteLine("Please enter the star-rating (1-5): ");
            content.StarRating = int.Parse(_console.ReadLine());
            // content.StarRatine = Convert.ToInt32(_console.ReadLine()); - would do the same thing

            // type of genre
            // need to be in same order as enum - uses the index or number of element in enum
            _console.WriteLine("Select a Genre: \n" +
                "1:  Horror \n" +
                "2:  Sci-Fi \n" +
                "3:  Drama \n" +
                "4.  Action \n" +
                "5:  Comedy \n" +
                "6:  Anime \n" +
                "7:  Documentary \n" +
                "8:  Thriller \n" +
                "9:  Romance");
            string genreInput = _console.ReadLine();
            // read line always returns a string
            int genreID = int.Parse(genreInput);
            // this is called casting
            content.TypeOfGenre = (GenreType)genreID;
            // AddContentToDirectory - method, content is variable
            // _stramingRepo is a field because we want it to be accessed through all methods
            _streamingRepo.AddContentToDirectory(content);
        }
        private void ShowAllContent()
        {
            _console.Clear();
            //get content
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();
            // iterate thru collection
            // made out of Streaming Content 
            // varialbe contentVariable
            foreach(StreamingContent contentVariable in listOfContent)
            {
                DisplayContent(contentVariable);
                _console.WriteLine("----------------------------");
            }

            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Enter a Title");
            string title = _console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);
            if(foundTitle != null)
            {
                DisplayContent(foundTitle);
            }
            else
            {
                _console.WriteLine("Invalid title. Could not find any results.");
            }
            _console.WriteLine("Press Any Key to continue");
            _console.ReadKey();
        }

        private void RemoveContentFromList()
        {
            _console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach (StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count} {content.Title}");
            }

            int targetContentID = int.Parse(_console.ReadLine());
            int targetIndex = targetContentID - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title}  successfully removed");
                }
                else
                {
                    _console.WriteLine($"I'm sorry, Dave.  I'm afraid I can't do that.");

                }

            }
            else
            {
                _console.WriteLine("No Content has that id");
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre: {content.Description} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Family Friendly:  {content.IsFamilyFriendly} \n" +
                $"Rating:  {content.MaturityRating}");
        }
        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Mr. Right","Hitman falls in love or something", MaturityRating.R,5,GenreType.Romance);
            StreamingContent movieTwo = new StreamingContent("Avatar", "Science Fiction Movie", MaturityRating.PG, 5, GenreType.Comedy);
            StreamingContent movieThree = new StreamingContent("Toy Story", "Childrens Movie", MaturityRating.G, 4, GenreType.Action);

            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
            _streamingRepo.AddContentToDirectory(movieThree);

        }
    }

    }

