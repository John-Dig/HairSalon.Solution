
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class St
  {
    public int StId { get; set; }
    public string Name { get; set; }
    public List<Cl> Cls { get; set; }
  }
}