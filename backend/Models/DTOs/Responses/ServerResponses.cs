using System.Collections.Generic;
using static Intalk.Models.UserServer;

namespace Intalk.Models.DTOs.Responses
{

    /// <summary>
    /// A response class for when a single server gets requested.
    /// </summary>
    public class SingleServerResponseItem
    {
        public long Id { get; set; }
        public string Title { get; set; }

        // TODO: Add channels
        // public IEnumerable<MultipleChannelsResponseItem> MyProperty { get; set; }
    }

    /// <summary>
    /// A response class for when multiple servers get requested.
    /// Used to avoid overposting.
    /// </summary>
    public class MultipleServersResponseItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
    }
}