using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace QuanLi
{
    public sealed class Database // sealed: prevents other classes from inheriting from this class
    {
        private string baseDataDir;

        private string extension;
        public string Extension
        {
            get => extension;
            set => extension = value;
        }

        private static Database database;

        private Database()
        {
            initPath();
        }

        public static Database Instance
        {
            get
            {
                database ??= new Database();
                return database;
            }
        }

        /// <summary>
        /// Create path for data
        /// </summary>
        private void initPath()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int index = baseDir.IndexOf("bin");
            baseDataDir = baseDir.Substring(0, index) + "Data\\";
            extension = ".csv";
        }

        private IEnumerable<T> GetAttributeValue<T>(object obj)
        {
            foreach (var proper in obj.GetType().GetProperties())
            {
                yield return (T)proper.GetValue(obj, null); // return without exit
            }
        }

        /// <summary>
        /// Write data to csv file
        /// </summary>
        /// <param name="obj"></param>
        public void WriteCSV<T>(List<T> obj, bool addTime = false)
        {
            string objectName = typeof(T).Name;
            string filePath = baseDataDir + objectName + extension;
            //int count = File.ReadLines(@"E:\File.txt").Count();
            
            StringBuilder csvStr = new StringBuilder();

            using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Append, FileAccess.Write), Encoding.UTF8))
            {
                foreach (object objItem in obj)
                {
                    StringBuilder newLine = new StringBuilder();
                    foreach (object attr in GetAttributeValue<object>(objItem))
                    {
                        if (attr == null)
                            return;

                        newLine.Append("," + attr.ToString());
                    }

                    if (addTime)
                        newLine.Append("," + DateTime.Now.ToString("dd/MM/yyyy"));

                    newLine.Remove(0, 1);
                    
                    writer.WriteLine(newLine.ToString());
                }
            }
        }

        /// <summary>
        /// Iterator for reading csv file line by line
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public IEnumerable<string[]> ReadCSV<T>()
        {
            string objectName = typeof(T).Name;
            string filePath = baseDataDir + objectName + extension;

            using (FileStream fs = new FileStream(filePath, FileMode.Open,
                                FileAccess.Read, FileShare.None, 65536,
                                FileOptions.SequentialScan))
            {
                using (StreamReader sReader = new StreamReader(fs))
                {
                    string line;
                    while ((line = sReader.ReadLine()) != null)
                    {
                        yield return line.Split(",");
                    }
                }
            }
        }

        /// <summary>
        /// Read csv and store it in a list
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        public List<T> ReadCSVToList<T>()
        {
            string objectName = typeof(T).Name;
            string filePath = baseDataDir + objectName + extension;
            List<string> listOfType = Enum.GetNames(typeof(Type)).ToList();

            if (typeof(T) == typeof(Dish))
            {
                List<Dish> menu = new List<Dish>();
                foreach (string[] sarr in ReadCSV<T>())
                {
                    if (!listOfType.Contains(sarr[5]))
                        continue;

                    Type tempEnum;
                    Enum.TryParse(sarr[5], out tempEnum);

                    try
                    {
                        Dish temp = new Dish
                        (
                            Convert.ToInt64(sarr[0]),
                            sarr[1],
                            Convert.ToDouble(sarr[2]),
                            Convert.ToDouble(sarr[3]),
                            Convert.ToInt32(sarr[4]),
                            tempEnum,
                            sarr[5]
                        );

                        menu.Add(temp);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                return menu as List<T>;
            }

            return new List<T> { };
        }
    }
}
