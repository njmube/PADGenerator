using System;
using System.IO;
using TAlex.PADGenerator.Models;


namespace TAlex.PADGenerator
{
    public interface IPADGenerator
    {
        void Generate(PADRoot root, Stream output);
    }
}
