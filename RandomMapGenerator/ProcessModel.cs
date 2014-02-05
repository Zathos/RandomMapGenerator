﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomMapGenerator.Tiles;
using RandomMapGenerator.Constants;

namespace RandomMapGenerator
{
    public class ProcessModel
    {
        public void GenerateOutputFromUserInput(InputValues inputvalues)
        {
            //pick first tile - any
            //generate grid from there...
            //build in memeory
            //Write to disk...

            //each level in a new file?
            //...
        }

        public IList<WidePathTile> GetAllTiles()
        {
        
            var TileTopBotom = new WidePathTile('║', 186, new List<Side> { Side.Top, Side.Bottom });
            var TileLeftRight = new WidePathTile('═', 205, new List<Side> { Side.Left, Side.Right });
            var TileLeftBottom = new WidePathTile('╗', 187, new List<Side> { Side.Left, Side.Bottom });
            var TileLeftTop = new WidePathTile('╝', 188, new List<Side> { Side.Left, Side.Top });
            var TileRightBottom = new WidePathTile('╔', 201, new List<Side> { Side.Right, Side.Bottom });
            var TileRightTop = new WidePathTile('╚', 200, new List<Side> { Side.Right, Side.Top });
            var TileLeftTopBottom = new WidePathTile('╣', 185, new List<Side> { Side.Left, Side.Top, Side.Bottom });
            var TileRightTopBottom = new WidePathTile('╠', 204, new List<Side> { Side.Right, Side.Top, Side.Bottom });
            var TileLeftRightBottom = new WidePathTile('╦', 203, new List<Side> { Side.Left, Side.Right, Side.Bottom });
            var TileLeftRightTop = new WidePathTile('╩', 202, new List<Side> { Side.Left, Side.Right, Side.Top });
            var TileLeftRightTopBottom = new WidePathTile('╬', 206, new List<Side> { Side.Left, Side.Right, Side.Top, Side.Bottom });
    }
    }
}
