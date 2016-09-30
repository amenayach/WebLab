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
using WebLab.Utilities;

namespace WebLab.UserControls
{
    public partial class ProjectTemplateBundlesUserControl : UserControl
    {

        private bool _trackItemCheck = true;
        private ProjectTemplate _selectedProjectTemplate;
        private List<Bundle> _bundles;

        public ProjectTemplateBundlesUserControl()
        {
            InitializeComponent();
        }

        public void LoadTemplate(ProjectTemplate selectedProjectTemplate)
        {
            try
            {
                if (selectedProjectTemplate != null)
                {

                    _selectedProjectTemplate = selectedProjectTemplate;
                    tbTemplateName.Text = selectedProjectTemplate.Name;

                    _bundles = BundleManager.Create(null).DataList;
                    lstAvailableBundles.FillCheckBoxList(_bundles, "Name", "Name");
                    lstSelectedBundles.FillListBox(_selectedProjectTemplate.Bundles, "Name", "Name");

                    ValidateTemplateBundles();

                }
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }

        private void ValidateTemplateBundles()
        {
            _trackItemCheck = false;

            if (_selectedProjectTemplate != null && _selectedProjectTemplate.Bundles.NotEmpty())
            {

                lstAvailableBundles.CheckAll(false);

                foreach (var bundle in _selectedProjectTemplate.Bundles)
                {

                    lstAvailableBundles.SetCheckedValues(new List<string>() { bundle.Name });

                }

            }

            _trackItemCheck = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedProjectTemplate != null)
            {
                ProjectTemplateManager.Create(null).Update(_selectedProjectTemplate, pTemplate => pTemplate.Name == _selectedProjectTemplate.Name);
            }
        }

        private void lstAvailableBundles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (_trackItemCheck)
                {
                    //todo add checked bundle to _selectedProjectTemplate.Bundles
                    ValidateTemplateBundles();

                }
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }
    }
}
