namespace AlbedoTeam.Identity.Contracts.Responses
{
    using Common;

    public interface ErrorResponse
    {
        ErrorType ErrorType { get; set; }
        string ErrorMessage { get; set; }
    }
}