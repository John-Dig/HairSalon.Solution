namespace HairSalon.Models
{
  public class Cl
  {
    public int ClId { get; set; }
    public string Description { get; set; }
    public int StId { get; set; }
    public St St { get; set; }
  }
}