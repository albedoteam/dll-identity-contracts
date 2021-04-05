namespace AlbedoTeam.Identity.Contracts.Requests
{
    using Common;

    public interface ListAuthServers
    {
        bool ShowDeleted { get; set; }
        int Page { get; set; }
        int PageSize { get; set; }
        string FilterBy { get; set; }
        string OrderBy { get; set; }
        Sorting Sorting { get; set; }
    }
}