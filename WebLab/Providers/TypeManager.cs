using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WebLab.Models;
using WebLab.Utilities;

namespace WebLab.Providers
{
    /// <summary>
    /// Manages the handled predefined types
    /// </summary>
    public class TypeManager<T>
    {

        /// <summary>
        /// Represents the types filename
        /// </summary>
        private readonly string _typesFilename;

        /// <summary>
        /// Represents the types
        /// </summary>
        public List<T> DataList { get; private set; }

        /// <summary>
        /// Creates an instance of TypeManager
        /// </summary>
        protected static TypeManager<T> Create(string typesFilename, List<T> defaultDataList)
        {
            return new TypeManager<T>(typesFilename, defaultDataList);
        }

        /// <summary>
        /// The Constructor that loads the types
        /// </summary>
        protected TypeManager(string typesFilename, List<T> defaultDataList)
        {
            _typesFilename = typesFilename;
            LoadTypes(defaultDataList);
        }

        /// <summary>
        /// Adds a new type
        /// </summary>
        public void Add(T type)
        {
            if (DataList == null)
            {
                DataList = new List<T>();
            }

            DataList.Add(type);
            SaveTypes();
        }

        /// <summary>
        /// Update a existing type according to a predicate
        /// </summary>
        public void Update(T type, Func<T, bool> predicate)
        {
            if (DataList == null)
            {
                DataList = new List<T>();
            }

            var targetedTypeIndex = DataList.FirstIndex(predicate);

            if (targetedTypeIndex > -1)
            {
                DataList[targetedTypeIndex] = type;
            }
            SaveTypes();
        }

        /// <summary>
        /// Remove a type
        /// </summary>
        public void Remove(T type)
        {
            if (DataList == null)
            {
                DataList = new List<T>();
            }

            DataList.Remove(type);
            SaveTypes();
        }

        /// <summary>
        /// Saves the current DataList
        /// </summary>
        public void SaveTypes()
        {
            var typesFullname = System.IO.Path.Combine(Application.StartupPath, _typesFilename);

            if (DataList == null)
            {
                DataList = new List<T>();
            }

            XmlSerializer.SaveFile(DataList, typesFullname);

        }

        /// <summary>
        /// Loads the types from xml if exists otherwise provides default types
        /// </summary>
        private void LoadTypes(List<T> defaultDataList)
        {

            var typesFullname = System.IO.Path.Combine(Application.StartupPath, _typesFilename);

            if (System.IO.File.Exists(typesFullname))
            {

                DataList = XmlSerializer.GetFile<T[]>(typesFullname).ToList();

            }
            else if (defaultDataList != null)
            {

                DataList = defaultDataList;
                XmlSerializer.SaveFile(defaultDataList, typesFullname);

            }

        }

    }
}
