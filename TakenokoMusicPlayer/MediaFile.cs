using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TakenokoMusicPlayer
{
    public class MediaFile
    {
        public String FilePath { get; set; }
        public String FileName
        {
            get
            {
                return Path.GetFileName(this.FilePath);
            }
        }

        public MediaFile(String filePath)
        {
            this.FilePath = filePath;
        }
    }
}
