//  Authors:  Srinivas S., Robert M. Scheller

using Landis.SpatialModeling;

namespace Landis.Extension.BiomassHarvest
{
    public class ShortPixel : Pixel
    {
        public Band<short> MapCode  = "The numeric code for each raster cell";

        public ShortPixel()
        {
            SetBands(MapCode);
        }
    }
}
