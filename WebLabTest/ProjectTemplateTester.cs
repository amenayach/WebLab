using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLab.Models;
using WebLab.Providers;

namespace WebLabTest
{
    public class ProjectTemplateTester : TestBase
    {
        protected override void Test()
        {
            //===================================================
            Write("Create and Add ProjectTemplate manager", () =>
            {
                var bees = ProjectTemplateManager.Create(new List<ProjectTemplate>());

                bees.Add(
                    new ProjectTemplate()
                    {
                        Name = "T1",
                        Bundles =
                        new List<Bundle>()
                        {
                            new Bundle()
                            {
                                Name = "jQuery",
                                Files = new List<BundleFile>()
                                {
                                    new BundleFile()
                                    {
                                        Id = 1,
                                        Name = "jQuery",
                                        Filename = @"E:\dada\j.js",
                                        Type = FileType.Script
                                    }
                                }
                            }
                        }
                    });

                bees.Add(
                    new ProjectTemplate()
                    {
                        Name = "T2",
                        Bundles =
                        new List<Bundle>()
                        {
                            new Bundle()
                            {
                                Name = "jQuery2",
                                Files = new List<BundleFile>()
                                {
                                    new BundleFile()
                                    {
                                        Id = 1,
                                        Name = "jQuery2",
                                        Filename = @"E:\dada\j2.js",
                                        Type = FileType.Script
                                    }
                                }
                            }
                        }
                    });
            });

            //===================================================
            Write("Remove bundle", () =>
            {
                var bees = ProjectTemplateManager.Create(null);

                bees.Remove(bees.DataList[0]);
            });


            //===================================================
            Write("Update template ", () =>
            {
                var bees = ProjectTemplateManager.Create(null);

                bees.DataList[0].Name = "NewName";
                bees.DataList[0].Bundles[0].Name = "NewFileName.js";
                bees.SaveTypes();

            });

        }

    }
}
