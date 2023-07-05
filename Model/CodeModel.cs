using System.ComponentModel.DataAnnotations;

public class Code
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Value { get; set; }
    public bool IsUsed { get; set; }
}