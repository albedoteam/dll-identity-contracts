namespace AlbedoTeam.Identity.Contracts.Common
{
    using System.Collections.Generic;

    public interface ICommunicationRule
    {
        string TemplateId { get; set; }
        Dictionary<string, string> DefaultContentParameters { get; set; }
    }
}