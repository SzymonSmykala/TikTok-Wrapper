using System.Collections.Generic;
using TikTokWrapper.Core.DTO;

namespace TikTokWrapper.Core
{
    public interface ITikTokManager
    {
        List<TikTok> GetTrending();
    }
}