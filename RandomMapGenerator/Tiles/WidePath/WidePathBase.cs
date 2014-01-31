using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomMapGenerator.Constants;

namespace RandomMapGenerator.Tiles
{
    public class WidePathBase
    {
        public char DisplayChar { get; }
        public string Description { get;  }
        public int TileValue { get; }
        public abstract IList<Sides> ValidSides { get; }
    }
}
