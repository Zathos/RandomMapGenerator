using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomMapGenerator.Constants;

namespace RandomMapGenerator
{
    public class InputValues
    {
        public OutputType MapType { get; set; }
        public string OutputPath { get; set; }
        public int XSize { get; set; }
        public int YSize { get; set; }
        public int ZSize { get; set; }

        public override string ToString()
        {
            var message = "User Selected Options:\n\n";
            message += string.Format("Output type is: {0}\n", MapType);
            message += string.Format("Output path: {0}\n", OutputPath);
            message += string.Format("Size of X: {0}\n", XSize);
            message += string.Format("Size of Y: {0}\n", YSize);
            message += string.Format("Size of Z: {0}\n", ZSize);
            return message;
        }
    }
}
