using FinancialAnalysis.src.entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinancialAnalysis.src.dao
{
    public class MainDAO
    {
        // ND - Name Directory
        private const string ND_DATA = "data";

        /// <summary>
        /// Метод создаёт директорию data если она отсутствует, 
        /// создаёт необходимый файл если он отсутствует и записывает в него переданую строку
        /// после возвращает полный путь к файлу
        /// </summary>
        /// <param name="nameFile"></param> // имя файла с раширением
        /// <returns></returns>
        public string CreatingdirectoryAndFile(string nameFile, string data)
        {
            // Получаем полный путь к файлу
            string fullPath = GetFullPath(nameFile);

            // Создаём директорию
            CreateDirectory();

            // Создать файл если он отсутствует
            if (!File.Exists(fullPath))
            {
                File.Create(fullPath).Close();

                // Запись данных в файл
                if (data != "")
                {
                    using (StreamWriter writer = new StreamWriter(fullPath))
                    {
                        writer.WriteLine(data);
                    }
                }
            }

            // возвращаем полный путь к файлу
            return fullPath;
        }

        // Создание директории data
        public void CreateDirectory()
        {
            // получить путь к папке в которой было запущено приложение
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // создаём папку для хранения файлов с данными если её нет
            DirectoryInfo dir = new DirectoryInfo(appDir);
            dir.CreateSubdirectory(ND_DATA);
        }

        // Метод возвращает полный путь к файлу, метод не проверяет его наличие
        public string GetFullPath(string nameFile)
        {
            nameFile = ND_DATA + @"\" + nameFile;

            // получить путь к папке в которой было запущено приложение
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // сформировать полный путь вместе с именем файла
            var fullPath = Path.Combine(appDir, nameFile);

            return fullPath;
        }

        // Сохранить переданный объект в указанный файл
        public void AddRecord<T>(T record, string nameFile)
        {
            string fullPath = CreatingdirectoryAndFile(nameFile, "");

            // Запись данных в файл
            using (StreamWriter writer = new StreamWriter(fullPath, append: true))
            {
                writer.WriteLine(record.ToString());
            }
        }

        // Получение id для нового объекта
        public int GetNewId(string nameFile)
        {
            string fullPath = CreatingdirectoryAndFile(nameFile, "0");

            int result;
            using (StreamReader reader = new StreamReader(fullPath))
            {
                result = int.Parse(reader.ReadLine());
            }

            // Запись данных в файл
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine(result + 1);
            }

            return result;
        }
    }
}
