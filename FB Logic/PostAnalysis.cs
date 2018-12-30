using System.Linq;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System.Text.RegularExpressions;
using System;

namespace FB_Logic
{
    public class PostAnalysis
    {
        public User TheUser { get; set; }

        public List<Post> PostsList { get; set; }

        public PostAnalysis(User i_User)
        {
            TheUser = i_User;
            initPostList();
        }

        public PostAnalysis()
        {
        }

        public List<Post> GetPostsByWord(string i_WordToSearch)
        {
            List<Post> filterdPostList = new List<Post>();
            foreach (Post post in PostsList)
            {
                if (post.Message.ToLower().Contains(i_WordToSearch.ToLower()))
                {
                    filterdPostList.Add(post);
                }
            }
            return filterdPostList;
        }

        private void initPostList()
        {
            PostsList = new List<Post>();
            foreach (Post post in TheUser.Posts)        // We get the posts here and just once
            {
                if (post.Message != null)
                {
                    PostsList.Add(post);
                }
            }
        }

        public Dictionary<string, int> GetTopKWords()
        {
            int k = 15;
            string input = string.Join(" ", setPostToStringList().ToArray());
            string[] words = Regex.Split(input, @"\W");
            var occurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowerWord = word.ToLowerInvariant();
                if (!occurrences.ContainsKey(lowerWord))
                {
                    occurrences.Add(lowerWord, 1);
                }
                else
                {
                    occurrences[lowerWord]++;
                }
            }

            return (from wp in occurrences.OrderByDescending(kvp => kvp.Value) select wp).Take(k).ToDictionary(kw => kw.Key, kw => kw.Value);
        }

        private List<string> setPostToStringList()
        {
            List<string> listResult = new List<string>();
            foreach (Post post in PostsList)
            {
                if (post.Message != null)
                {
                    listResult.Add(post.Message);
                }
            }
            return listResult;
        }

        public List<Post> SortByParameter(string i_SortKindName, List<Post> i_DisplayedPosts)
        {
            List<Post> sortedList = new List<Post>();
            sortedList = i_DisplayedPosts;
            sortedList.Sort(FactoryPostSorts.SortMethod(i_SortKindName));
            return sortedList;
        }
    }
}
