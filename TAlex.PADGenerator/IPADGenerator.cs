using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TAlex.PADGenerator.Models;

namespace TAlex.PADGenerator
{
    public interface IPADGenerator
    {
        void Generate(PADRoot root, Stream output);
    }
}
