using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_Magnets
{
    class Flobbo
    {
        private string zap;
        public Flobbo(string zap)
        {
            this.zap = zap;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter("macaw.txt");
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(zap);
            zap = "green pruple";
            return false;
        }
        public bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(zap);
                zap = "green pruple";
                return true;
            }
            
        }
    }
}
