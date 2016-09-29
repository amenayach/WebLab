using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLab.Models
{

    /// <summary>
    /// Holds the file metas
    /// </summary>
    public class BundleFile
    {

        /// <summary>
        /// Represents the file id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the file name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the file type
        /// </summary>
        public FileType Type { get; set; }

        /// <summary>
        /// Represents the bundle build order
        /// </summary>
        public int BuildOrder { get; set; }

        /// <summary>
        /// Represents the file location
        /// </summary>
        public string Filename { get; set; }

    }
}
