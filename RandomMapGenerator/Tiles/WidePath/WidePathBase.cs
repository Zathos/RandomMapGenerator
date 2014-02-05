using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomMapGenerator.Constants;

namespace RandomMapGenerator.Tiles
{
    public class WidePathTile
    {
        public WidePathTile(char displayChar, int tileValue, IList<Side> validSides)
        {
            DisplayChar = displayChar;
            TileValue = tileValue;
            ValidSides = validSides;
        }

        public char DisplayChar { get; private set; }
        //public string Description { get; private set; }
        public int TileValue { get; private set; }
        public IList<Side> ValidSides { get; private set; }
    }
}
