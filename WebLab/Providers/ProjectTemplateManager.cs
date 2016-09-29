using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WebLab.Models;

namespace WebLab.Providers
{
    /// <summary>
    /// Manages the handled predeined types
    /// </summary>
    public class ProjectTemplateManager : TypeManager<ProjectTemplate>
    {
        public ProjectTemplateManager(string typesFilename, List<ProjectTemplate> defaultDataList) : base(typesFilename, defaultDataList)
        {

        }

        /// <summary>
        /// Creates an instance of ProjectTemplate manager
        /// </summary>
        public static ProjectTemplateManager Create(List<ProjectTemplate> defaultDataList)
        {
            return new ProjectTemplateManager("ProjectTemplates.xml", defaultDataList);
        }

    }
}
