using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebusOps
{
    public class Answer
    {
        public string Text { get; set; }
        public byte[] ImageData { get; set; }

        public Answer(string text, byte[] imageData)
        {
            Text = text;
            ImageData = imageData;
        }
    }

}
