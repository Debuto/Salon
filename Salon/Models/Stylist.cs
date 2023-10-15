using System.Collections.Generic;
using MySqlConnector;

namespace Salon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public int StylistId { get; set; }
    public List<Client> Clients { get; set; }
  }
}