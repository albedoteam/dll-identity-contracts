namespace AlbedoTeam.Identity.Contracts.Common
{
    public interface ICommunicationRules
    {
        ICommunicationRule OnUserCreated { get; set; }
        ICommunicationRule OnPasswordChangeRequested { get; set; }
        ICommunicationRule OnPasswordChanged { get; set; }
        ICommunicationRule OnUserActivated { get; set; }
        ICommunicationRule OnUserDeactivated { get; set; }
    }
}