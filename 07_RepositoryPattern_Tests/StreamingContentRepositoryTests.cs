﻿using System;
using System.Collections.Generic;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange 
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            //Act
            bool addResult = repo.AddContentToDirectory(content);

            // Assert
            Assert.IsTrue(addResult);

        }
        [TestMethod]

        public void GetContents_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(content);
            //Act
            List<StreamingContent> contents = repo.GetContents();
            bool directoryHasContent = contents.Contains(content);
           //Assert.IsTrue(directoryHasContent);
        }
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Mr. Right", "Hitman falls in love", MaturityRating.R, 100, GenreType.Action);
            _repo.AddContentToDirectory(_content);

        }
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //ACT
            StreamingContent searchResult = _repo.GetContentByTitle("Mr. Right");
            //Assert!
            Assert.AreEqual(_content, searchResult);
        }

        // DRT (do not repeat yourself)
        // WET (We enjoy typing)

        [TestMethod]

        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Mr. Right", "Hitman falls in love", MaturityRating.R, 100, GenreType.Romance);

            bool updatedResult = _repo.UpdateExistingContent("Mr. Right", newContent);
            Assert.IsTrue(updatedResult);
            Assert.AreEqual(GenreType.Romance, _content.TypeOfGenre);


        }
        [TestMethod]

        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Mr. Right");
            //Act
            bool removeResult = _repo.DeleteExistingContent(content);
            //Assert
            Assert.IsTrue(removeResult);

        }

        // Challenge Test for Description
        [TestMethod]
        public void GetByDesc_ShouldReturnCorrectContent()
        {
            //Arrange
            //ACT
            StreamingContent searchResult = _repo.GetContentByDesc("Hitman falls in love");
            //Assert!
            Assert.AreEqual(_content, searchResult);
        }

    }
}
