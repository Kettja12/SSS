using System.ComponentModel.DataAnnotations;

namespace SSS.Repositories
{
    public record AppSetting
    {
        [Key]
        public string Key { get; set; } = string.Empty;
        public string SValue { get; set; } = string.Empty;
    }
}