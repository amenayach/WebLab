using System.IO;
using System.Windows.Forms;

namespace WebLab.Providers
{

    /// <summary>
    /// Helps to get or set data into xml files
    /// </summary>
    public class XmlSerializer
    {

        /// <summary>
        /// Get object from xml
        /// </summary>
        public static T GetFile<T>(string filename) where T : class
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(T));

            var filePath = Path.Combine(Application.StartupPath, filename);

            if (new FileInfo(filePath).Exists)
            {

                var file = new StreamReader(filePath);

                var data = reader.Deserialize(file);

                file.Close();

                if (data != null)
                {
                    return (T)data;
                }

            }

            return null;

        }

        /// <summary>
        /// Save object into xml
        /// </summary>
        public static void SaveFile<T>(T objectInstance, string filename)
        {

            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            FileStream file = File.Create(Path.Combine(Application.StartupPath, filename));

            writer.Serialize(file, objectInstance);

            file.Close();

        }

    }
}
