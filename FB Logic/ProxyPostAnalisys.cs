using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FB_Logic
{
    public class ProxyPostAnalisys : PostAnalysis, IPostAnalysis
    {
        private List<Post> m_offlinePostsList;

        public ProxyPostAnalisys(List<Post> i_offlinePostsList)
        {
            m_offlinePostsList = i_offlinePostsList;
            initPostList();
        }

        public void initPostList()
        {
            PostsList = m_offlinePostsList;
        }
    }
}