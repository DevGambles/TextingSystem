﻿namespace TextingSystem.Services.Messaging.Common.Client
{
    public class CreateClientRequest
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

