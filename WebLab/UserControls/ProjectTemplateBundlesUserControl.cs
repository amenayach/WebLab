using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebLab.Models;
using WebLab.Providers;

namespace WebLab.UserControls
{
    public partial class ProjectTemplateBundlesUserControl : UserControl
    {

        private ProjectTemplate _selectedProjectTemplate;

        public ProjectTemplateBundlesUserControl()
        {
            InitializeComponent();
        }

        public void LoadTemplate(ProjectTemplate selectedProjectTemplate)
        {
            if (selectedProjectTemplate != null)
            {

                _selectedProjectTemplate = selectedProjectTemplate;
                tbTemplateName.Text = selectedProjectTemplate.Name;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedProjectTemplate != null)
            {
                ProjectTemplateManager.Create(null).Add(_selectedProjectTemplate);
            }
        }
    }
}
