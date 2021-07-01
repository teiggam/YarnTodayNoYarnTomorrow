using System;
using System.Collections.Generic;

#nullable disable

namespace YarnTodayStorefront.Models2
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public decimal? Wallet { get; set; }
    }
}
