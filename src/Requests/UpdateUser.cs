using System.Collections.Generic;

namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface UpdateUser
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string Username { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        Dictionary<string, string> CustomProfileFields { get; set; }
    }
}