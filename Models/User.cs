using System.Collections.Generic;

namespace dotnet_rpg.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Character> Characters { get; set; }
    }
}