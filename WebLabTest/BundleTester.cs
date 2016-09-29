using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLab.Models;
using WebLab.Providers;

namespace WebLabTest
{
    public class BundleTester : TestBase
    {
        protected override void Test()
        {
            //===================================================
            Write("Create bundle manager", () =>
            {
                var bees = BundleManager.Create(
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
                   }).DataList;
            });

            //===================================================
            Write("Add bundle to bundle manager", () =>
            {
                var bees = BundleManager.Create(null);

                bees.Add(
                   new Bundle()
                   {
                       Name = "jQueryVal",
                       Files = new List<BundleFile>()
                       {
                           new BundleFile()
                           {
                               Id = 1,
                               Name = "jQueryVal",
                               Filename = @"E:\dada\jval.js",
                               Type = FileType.Script
                           },
                           new BundleFile()
                           {
                               Id = 1,
                               Name = "jQueryValStyle",
                               Filename = @"E:\dada\jval.css",
                               Type = FileType.Style
                           }
                       }
                   });
            });

            //===================================================
            Write("Remove bundle", () =>
            {
                var bees = BundleManager.Create(null);

                bees.Remove(bees.DataList[0]);
            });


            //===================================================
            Write("Update bundle ", () =>
            {
                var bees = BundleManager.Create(null);

                bees.DataList[0].Name = "NewName";
                bees.DataList[0].Files[0].Name = "NewFileName.js";
                bees.SaveTypes();

            });

        }

    }
}
