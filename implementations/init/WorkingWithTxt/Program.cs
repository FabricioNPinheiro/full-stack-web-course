using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace WorkingWithTxt {
    class Program {
        static void Main(string[] args) {
          var path = "/home/fabricionogueira/full-stack-web-course/material/temp";

          File.Copy(@"testado.jpg", @"myfile.jpg", true);
          File.Delete(path);
          if (File.Exists(path)) {
              Console.WriteLine("Not");
          } 

          var content = File.ReadAllText(path);

          var fileInfo = new FileInfo(path);
          fileInfo.CopyTo("...");
          fileInfo.Delete();
          if (fileInfo.Exists) {
              //
          }
        }
    }
}
