using System;
using System.Collections.Generic;
using System.Text;

namespace Ruanmou.Core.Utility
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LoginTime { get; set; } 
        public string Role { get; set; }
    }
}
