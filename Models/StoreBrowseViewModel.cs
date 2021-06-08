using System.Collections.Generic;

namespace Dojo_FeatureTogglesCore.Models
{
  public class StoreBrowseViewModel
  {
    public Genre Genre { get; set; }

    public List<Album> Albums { get; set; }
  }
}