namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface ExpireUserPassword
    {
        string AccountId { get; set; }
        string Id { get; set; }
        string Reason { get; set; }
    }
}