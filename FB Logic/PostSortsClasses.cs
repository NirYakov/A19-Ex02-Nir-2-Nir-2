using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    internal class SortPostByLikes : IComparer<Post>
    {
        public int Compare(Post i_X, Post i_Y)
        {
            return i_Y.LikedBy.Count.CompareTo(i_X.LikedBy.Count);
        }
    }

    internal class SortPostAlphabetical : IComparer<Post>
    {
        public int Compare(Post i_X, Post i_Y)
        {
            return i_X.Message.CompareTo(i_Y.Message);
        }
    }
    internal class SortPostByRecent : IComparer<Post>
    {
        public int Compare(Post i_X, Post i_Y)
        {
            return i_Y.UpdateTime.Value.CompareTo(i_X.UpdateTime.Value);
        }
    }
}
