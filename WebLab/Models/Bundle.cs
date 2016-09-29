using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLab.Models
{

    /// <summary>
    /// Holds a set of BundleFiles
    /// </summary>
    public class Bundle
    {

        /// <summary>
        /// Represents the bundle name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the bundle build order
        /// </summary>
        public int BuildOrder { get; set; }

        /// <summary>
        /// Represents the bundle files
        /// </summary>
        public List<BundleFile> Files { get; set; }

    }
}
