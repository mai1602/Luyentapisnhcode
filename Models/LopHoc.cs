using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.ResponseCompression;

namespace luyentap.Models
{
  public class Model 
  {
    [Key]
    public string MaLop { get; set; }
    public string Tenlop { get; set; }
  }
}