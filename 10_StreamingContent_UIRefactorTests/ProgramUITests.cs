using System;
using System.Collections.Generic;
using _09_StreamingContent_Console;
using _09_StreamingContent_Console.UI;
using _10_StreamingContent_UIRefactorTests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_StreamingContent_UIRefactorTests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainList()
        {
            // Arrange 
            List<string> commandList = new List<string> { "1", "5" };
            MockConsole console = new MockConsole(commandList);
            ProgramUI program = new ProgramUI(console);

            // Act
            program.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains("Avatar"));

        }
        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            // setup test - Arrange
            var customDesc = "This is my customer Description";
            var commandList = new List<string> { "3", "Title", customDesc, "4", "1", "8", "1", "5" };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            //Act
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains(customDesc));


        }
    }
}
