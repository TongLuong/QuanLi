﻿using System.Collections.Generic;
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
                if (database == null)
                    database = new Database();
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
            string objectName = null;

            if (!addTime)
                objectName = typeof(T).Name;
            else
                objectName = @DateTime.Now.ToString("dd-MM-yyyy");

            string filePath = baseDataDir + objectName + extension;
            //int count = File.ReadLines(@"E:\File.txt").Count();

            StringBuilder csvStr = new StringBuilder();

            using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Append, FileAccess.Write), Encoding.UTF8))
            {
                foreach (object objItem in obj)
                {
                    StringBuilder newLine = new StringBuilder();
                    int count = 0;
                    foreach (object attr in GetAttributeValue<object>(objItem))
                    {
                        if (attr == null)
                            return;

                        count++;
                        if (attr.ToString() == "" && count >= 8)
                        {
                            if (addTime)
                            {
                                newLine.Append("," + DateTime.Now.ToString("dd/MM/yyyy"));
                                continue;
                            }
                        }

                        newLine.Append("," + attr.ToString());
                    }

                    newLine.Remove(0, 1);

                    writer.WriteLine(newLine.ToString());
                }
            }
        }

        /// <summary>
        /// Iterator for reading csv file line by line
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="date">Format "dd-mm-yyyy"</param>
        /// <returns></returns>
        public IEnumerable<string[]> ReadCSV<T>(string date = null)
        {
            string objectName = typeof(T).Name;
            string filePath = "";

            if (date == null)
                filePath = baseDataDir + objectName + extension;
            else
                filePath = baseDataDir + date + extension;

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
        /// <typeparam name="T"></typeparam>
        /// <param name="date">Format "dd-mm-yyyy"</param>
        /// <returns></returns>
        public List<T> ReadCSVToList<T>(string date = null)
        {
            string objectName = typeof(T).Name;
            string filePath = "";

            if (date == null)
                filePath = baseDataDir + objectName + extension;
            else
                filePath = baseDataDir + date + extension;

            List<string> listOfType = Enum.GetNames(typeof(Type)).ToList();

            if (typeof(T) == typeof(Dish))
            {
                List<Dish> menu = new List<Dish>();
                foreach (string[] sarr in ReadCSV<T>(date))
                {
                    if (!listOfType.Contains(sarr[5]))
                        continue;

                    Type tempEnum;
                    Enum.TryParse(sarr[5], out tempEnum);

                    string time = "";
                    if (sarr.Length < 8)
                        time = "";
                    else
                        time = sarr[7];

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
                            sarr[6],
                            time
                        );

                        menu.Add(temp);
                    }
                    catch (Exception ex)
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