namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface GetPasswordRecovery
    {
        string AccountId { get; set; }
        string ValidationToken { get; set; }
    }
}