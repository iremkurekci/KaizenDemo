using System.ComponentModel.DataAnnotations;

public class Campaign
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    public string Code { get; set; }
    public bool IsValid { get; set; }
}