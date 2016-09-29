using System;
using System.Linq;
using System.Windows.Forms;
using WebLab.Models;
using WebLab.Providers;
using WebLab.Utilities;

namespace WebLab.UserControls
{
    public partial class ProjectTemplatesUserControl : UserControl
    {

        public delegate void TemplateSelectionHandler(object sender, TemplateSelectionEventArgs e);

        public event TemplateSelectionHandler SelectedTemplateChanged;

        private ProjectTemplateManager _projectTemplate;

        public ProjectTemplatesUserControl()
        {
            InitializeComponent();
        }

        private void ProjectTemplatesUserControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

                LoadProjectTemplates();

            }
        }

        private void LoadProjectTemplates()
        {
            try
            {

                if (_projectTemplate == null)
                {
                    _projectTemplate = ProjectTemplateManager.Create(null);
                }

                lstProjectTemplates.DisplayMember = "Name";
                lstProjectTemplates.ValueMember = "Name";
                lstProjectTemplates.DataSource = tbSearch.Text.NotEmpty() && _projectTemplate.DataList.NotEmpty()
                    ? _projectTemplate.DataList.Where(template => template.Name.ToLower().Contains(tbSearch.Text.ToLower())).ToList()
                    : _projectTemplate.DataList;

            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProjectTemplates();
        }

        private void lstProjectTemplates_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up && lstProjectTemplates.SelectedIndex == 0)
                {
                    tbSearch.Focus();
                    tbSearch.SelectAll();
                }
            }
            catch 
            {
                // Ignored
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    lstProjectTemplates.Focus();
                }
            }
            catch
            {
                // Ignored
            }
        }
        
        private void lstProjectTemplates_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedTemplateChanged?.Invoke(this, new TemplateSelectionEventArgs(lstProjectTemplates.SelectedItem as ProjectTemplate));
        }
    }

    public class TemplateSelectionEventArgs : EventArgs
    {
        public TemplateSelectionEventArgs(ProjectTemplate selectedProjectTemplate)
        {
            SelectedProjectTemplate = selectedProjectTemplate;
        }

        public ProjectTemplate SelectedProjectTemplate { get; private set; }
    }
}
