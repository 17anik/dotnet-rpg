using dotnet_rpg.Models;

namespace dotnet_rpg.DTOs.Character
{
    public class UpdateCharacterDTO
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Geralt";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Witcher;
    }
}