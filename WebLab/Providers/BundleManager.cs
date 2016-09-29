using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WebLab.Models;

namespace WebLab.Providers
{
    /// <summary>
    /// Manages the handled predeined types
    /// </summary>
    public class BundleManager : TypeManager<Bundle>
    {
        private BundleManager(string typesFilename, List<Bundle> defaultDataList) : base(typesFilename, defaultDataList)
        {

        }

        /// <summary>
        /// Creates an instance of bundle manager
        /// </summary>
        public static BundleManager Create(List<Bundle> defaultDataList)
        {
           return new BundleManager("Bundles.xml", defaultDataList);
        }

    }
}
