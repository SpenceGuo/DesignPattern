using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PrototypeSample
{
    [Serializable]
    class WeeklyLog
    {
        private Attachment attachment;
        private string name;
        private string date;     
        private string content;

        public Attachment Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        /*
        //使用MemberwiseClone()方法实现浅克隆
        public WeeklyLog Clone()
        {
            return this.MemberwiseClone() as WeeklyLog;
        }
         */

        //使用序列化方式实现深克隆
        public WeeklyLog Clone()
        {
            WeeklyLog clone = null;
            FileStream fs = new FileStream("Temp.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            FileStream fs1 = new FileStream("Temp.dat", FileMode.Open);
            BinaryFormatter formatter1 = new BinaryFormatter();
            try
            {
                clone = (WeeklyLog)formatter1.Deserialize(fs1);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            return clone;
        }
    }
}
