namespace AlbedoTeam.Identity.Contracts.Requests
{
    using Common;

    public interface ListUserTypes
    {
        string AccountId { get; set; }
        bool ShowDeleted { get; set; }
        int Page { get; set; }
        int PageSize { get; set; }
        string FilterBy { get; set; }
        string OrderBy { get; set; }
        Sorting Sorting { get; set; }
    }
}