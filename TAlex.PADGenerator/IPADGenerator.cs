using System;
using System.IO;
using TAlex.PADGenerator.Models;


namespace TAlex.PADGenerator
{
    /// <summary>
    /// Represents the functionality for generating PAD (Portable Application Description) file.
    /// </summary>
    public interface IPADGenerator
    {
        /// <summary>
        /// Generates xml PAD file and puts to output stream.
        /// </summary>
        /// <param name="root">A root elemnt model for PAD file.</param>
        /// <param name="output">An output stream for writing generated PAD file.</param>
        void Generate(PADRoot root, Stream output);
    }
}
