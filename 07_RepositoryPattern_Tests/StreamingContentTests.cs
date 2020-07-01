using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);

        }
        public void SetStarRating_ShouldSetCorrectInt()
        {
            StreamingContent content = new StreamingContent();
            content.StarRating = 5;

            int shouldBe = 5;
            int valueIs = content.StarRating;

            Assert.AreEqual(shouldBe, valueIs);
        }
       // public void SetIsFamilyFriendly_ShouldSetCorrectBool()
       // {

       //     StreamingContent content = new StreamingContent();
       //     content.IsFamilyFriendly = true;

       //     bool expecting = true;
        //    bool settingIs = content.IsFamilyFriendly;
//
       //     Assert.AreEqual(expecting, settingIs);

            

       // }
        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Romance)]
        [DataRow(GenreType.Comedy)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            // AAA Paradim
            //Arrange
            StreamingContent content = new StreamingContent();
            //Act
            content.TypeOfGenre = typeOfGenre;
            //Assert
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }
    }
}

