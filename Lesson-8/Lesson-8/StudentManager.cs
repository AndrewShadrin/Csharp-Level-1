using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Task3
{
    public static class StudentManager
    {
        /// <summary>
        /// Читает список студентов из файла csv
        /// </summary>
        /// <param name="fileName">Имя файла для чтения</param>
        /// <returns>Список студентов</returns>
        public static List<Student> CreateStudents(string fileName)
        {
            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка чтения файла данных: "+ex.Message);
                }
            }
            sr.Close();

            return list;
        }

        /// <summary>
        /// Производит сериализацию списка студентов в XML
        /// </summary>
        /// <param name="list">Список студентов</param>
        /// <param name="fileName">Имя файла для сохранения</param>
        public static void XMLSerialize(List<Student> list, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            // Создаем файловый поток(проще говоря, создаем файл)
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            // В этот поток записываем сериализованные данные(записываем xml-файл)
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>
        /// Производит сериализацию списка студентов в JSON
        /// </summary>
        /// <param name="list">Список студентов</param>
        /// <param name="fileName">Имя файла для сохранения</param>
        public static void SaveToJSON(List<Student> list, string fileName)
        {
            StreamWriter jsonFile = new StreamWriter(fileName, false);
            JsonSerializer json = new JsonSerializer();
            json.Serialize(jsonFile, list);
            jsonFile.Close();
        }

        /// <summary>
        /// Производит сохранение списка студентов в XML (поля сохраняются в атрибуты)
        /// </summary>
        /// <param name="list">Список студентов</param>
        /// <param name="fileName">Имя файла для сохранения</param>
        public static void SaveToXML(List<Student> list, string fileName)
        {
            Stream xmlFile = new FileStream(fileName, FileMode.Create);
            XmlTextWriter textWriter = new XmlTextWriter(xmlFile, Encoding.Unicode);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Students");

            foreach (var item in list)
            {
                textWriter.WriteStartElement("Student");
                textWriter.WriteAttributeString("firstName", item.firstName);
                textWriter.WriteAttributeString("lastName", item.lastName);
                textWriter.WriteAttributeString("university", item.university);
                textWriter.WriteAttributeString("faculty", item.faculty);
                textWriter.WriteAttributeString("department", item.department);
                textWriter.WriteAttributeString("course", item.course.ToString());
                textWriter.WriteAttributeString("age", item.age.ToString());
                textWriter.WriteAttributeString("group", item.group.ToString());
                textWriter.WriteAttributeString("city", item.city);
                textWriter.WriteEndElement();
            }

            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
            xmlFile.Close();
        }
    }
}
