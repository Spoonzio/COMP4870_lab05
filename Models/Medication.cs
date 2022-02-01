using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthAPI.Models;

public class Medication
{
    [Key]
    public string? Name { get; set; }
    public string? Doses { get; set; }


    [ForeignKey("PatientId")]
    public Patient? Patient { get; set; }
    public int PatientId { get; set; }
}

