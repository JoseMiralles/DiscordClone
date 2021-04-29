namespace Intalk.Models.DTOs.Responses
{

    /// <summary>
    /// A response class for when a single server gets requested.
    /// </summary>
    public class SingleServerResponseItem
    {
        public string Id { get; set; }
        public string Title { get; set; }

        // TODO: Add channels
        // public IEnumerable<MultipleChannelsResponseItem> MyProperty { get; set; }
    }

    /// <summary>
    /// A response class for when multiple servers get requested.
    /// </summary>
    public class MultipleServersResponseItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
}