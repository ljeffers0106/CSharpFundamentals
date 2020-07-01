using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{   
    
    
    public class StreamingContentRepository
    {
        // protected - can only access ?
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        
        //CRUD
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;

        }
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower()== title.ToLower())
                {
                    return content;
                }

            }
            return null;
        }
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;

        }
        // Build Methods
        // Get by Other parameters
        // get by Rating
        // get by family Friendly
        // etc


        // Challenge Get by other parameter - description
        public StreamingContent GetContentByDesc(string description)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Description.ToLower() == description.ToLower())
                {
                    return content;
                }

            }
            return null;
        }
        // Challenge Get by Family Friendly

        public List<StreamingContent> getByIsFamilyFriendly(bool isFamilyFriendly)
        {
            List<StreamingContent> sortedList = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == isFamilyFriendly)
                {
                    sortedList.Add(content);
                }
            }
            return sortedList;
        }

    }
}
