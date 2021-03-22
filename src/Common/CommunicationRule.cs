using System.Collections.Generic;

namespace AlbedoTeam.Identity.Contracts.Common
{
    public interface CommunicationRule
    {
        string TemplateId { get; set; }
        Dictionary<string, string> DefaultContentParameters { get; set; }
    }
}