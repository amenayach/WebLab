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
        private Toastr _toastr;

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

                if (ParentForm != null)
                {
                    _toastr = new Toastr(this.ParentForm,
                        ParentForm.PointToClient(btnSave.PointToScreen(new Point(btnSave.Location.X + btnSave.Width * 2, -100))),
                        ParentForm.PointToClient(btnSave.PointToScreen(new Point(btnSave.Location.X + btnSave.Width * 2, btnSave.Location.Y))), 2500);
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
                _toastr.Show("Saved succeeded :)");
            }
        }

        private void lstAvailableBundles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (_trackItemCheck)
                {
                    if (_selectedProjectTemplate != null)
                    {

                        var similarItem = _selectedProjectTemplate.Bundles.FirstOrDefault(bundle => bundle.Name == (lstAvailableBundles.Items[e.Index] as Bundle)?.Name);
                        if (e.NewValue == CheckState.Checked)
                        {
                            if (similarItem == null)
                            {
                                _selectedProjectTemplate.Bundles.Add(lstAvailableBundles.Items[e.Index] as Bundle);
                            }
                        }
                        else
                        {
                            if (similarItem != null)
                            {
                                _selectedProjectTemplate.Bundles.Remove(similarItem);
                            }
                        }

                    }
                    ValidateTemplateBundles();

                }
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }

        private void ProjectTemplateBundlesUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
