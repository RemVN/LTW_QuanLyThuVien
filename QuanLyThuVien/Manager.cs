using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace QuanLyThuVien
{
    abstract class Manager
    {

        public Manager()
        {
        }

        public abstract void refreshDataGridView();
        public abstract void initForm();
        public abstract void load();
        public abstract void save();

        public void saveObject(object obj, string fileName, Type type)
        {
            FileStream fileStream = getFileStream(fileName, true);
            StreamWriter streamWriter = getStreamWriter(fileStream);
            XmlSerializer xmlSerializer = getXmlSerializer(type);
            xmlSerializer.Serialize(streamWriter, obj);
            streamWriter.Close();
            fileStream.Close();
        }

        public object loadObject(string fileName, Type type)
        {
            FileStream fileStream = getFileStream(fileName, false);
            StreamReader streamReader = getStreamReader(fileStream);
            XmlSerializer xmlSerializer = getXmlSerializer(type);
            object obj = xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
            fileStream.Close();
            return obj;
        }

        public bool isFileExist(string fileName)
        {
            return File.Exists(fileName);
        }

        public FileStream getFileStream(string fileName, bool save)
        {
            if(save)
            {
                FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                return fileStream;
            } else
            {
                FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                return fileStream;
            }
        }

        public StreamWriter getStreamWriter(FileStream fileStream)
        {
            return new StreamWriter(fileStream);
        }

        public StreamReader getStreamReader(FileStream fileStream)
        {
            return new StreamReader(fileStream);
        }

        public XmlSerializer getXmlSerializer(Type type)
        {
            return new XmlSerializer(type);
        }

    }
}
