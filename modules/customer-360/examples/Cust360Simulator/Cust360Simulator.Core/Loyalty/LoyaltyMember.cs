﻿namespace Cust360Simulator.Core.Loyalty
{
    public class LoyaltyMember
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
    }
}