using AlbedoTeam.Identity.Contracts.Common;

namespace AlbedoTeam.Identity.Contracts.Responses
{
    public interface ErrorResponse
    {
        ErrorType ErrorType { get; set; }
        string ErrorMessage { get; set; }
    }
}