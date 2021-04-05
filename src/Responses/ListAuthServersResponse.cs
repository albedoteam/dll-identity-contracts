namespace AlbedoTeam.Identity.Contracts.Responses
{
    using System.Collections.Generic;
    using Common;

    public interface ListAuthServersResponse
    {
        int Page { get; set; }
        int PageSize { get; set; }
        int RecordsInPage { get; set; }
        int TotalPages { get; set; }
        string FilterBy { get; set; }
        string OrderBy { get; set; }
        Sorting Sorting { get; set; }
        List<AuthServerResponse> Items { get; set; }
    }
}