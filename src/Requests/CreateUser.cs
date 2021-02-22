﻿using System.Collections.Generic;

namespace AlbedoTeam.Identity.Contracts.Requests
{
    public interface CreateUser
    {
        string AccountId { get; set; }
        string UserTypeId { get; set; }
        string Username { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        Dictionary<string, string> CustomProfileFields { get; set; }
        List<string> Groups { get; set; }
    }
}