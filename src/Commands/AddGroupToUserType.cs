namespace AlbedoTeam.Identity.Contracts.Commands
{
    public interface AddGroupToUserType
    {
        string AccountId { get; set; }
        string UserTypeId { get; set; }
        string GroupId { get; set; }
    }
}