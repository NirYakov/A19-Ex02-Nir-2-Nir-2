using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    internal static class FactoryPostSorts
    {
        // Alphabetical, Recent , Likes

        internal static IComparer<Post> SortMethod(string i_SortName)
        {
            const string recent = "Recent", likes = "Likes", alphabetical = "Alphabetical";

            IComparer<Post> sortMethod = null;

            switch (i_SortName)
            {
                case recent:
                    break;
                case likes:
                    sortMethod = new SortPostByLikes();
                    break;
                case alphabetical:
                    sortMethod = new SortPostAlphabetical();
                    break;
                default:
                    throw new ArgumentException();
            }

            return sortMethod;
        }
    }
}
