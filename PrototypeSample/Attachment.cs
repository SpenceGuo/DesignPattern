using System;

namespace PrototypeSample
{
    [Serializable]
    class Attachment
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Download()
        {
            Console.WriteLine("下载附件，文件名为{0}。",name);
        }
    }
}
