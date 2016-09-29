using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLab.Models
{
    /// <summary>
    /// Holds a projecte bundles
    /// </summary>
    public class ProjectTemplate
    {

        /// <summary>
        /// Represents the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the template bundles
        /// </summary>
        public List<Bundle> Bundles { get; set; }
        
        /// <summary>
        /// Create a project respecting the bundle build order
        /// </summary>
        public void CreateProjectInstance(string projectName)
        {
            //todo
        }

    }
}
