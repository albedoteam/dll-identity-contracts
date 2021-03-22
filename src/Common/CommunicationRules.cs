namespace AlbedoTeam.Identity.Contracts.Common
{
    public interface CommunicationRules
    {
        CommunicationRule OnUserCreated { get; set; }
        CommunicationRule OnPasswordChangeRequested { get; set; }
        CommunicationRule OnPasswordChanged { get; set; }
        CommunicationRule OnUserActivated { get; set; }
        CommunicationRule OnUserDeactivated { get; set; }
    }
}