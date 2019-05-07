using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_RemoveDuplication
{
    public abstract class Duplications
    {
        public abstract void saveFile(String filename, String fileContent);
        public abstract String readFile(String filename);
        public abstract void log(String level, String message);
        public void createFile()
        {
            try
            {
                this.saveFile("Greetings.txt", "Beyond Java says \\\"Hello World!\\\"\")");
            }
            catch (IOException error)
            {
                //  please provide better error diagnosis in real life!
                this.log("Error", "Can\'t write the file due to an exception");
            }
        }
        public void copyFile()
        {
            try
            {
                String fileContents = this.readFile("OldFileName.txt");
                try
                {
                    this.saveFile("Greetings.txt", fileContents);
                }
                catch (IOException error)
                {
                    //  please provide better error diagnosis in real life!
                    this.log("Error", "Can\'t write the file due to an exception");
                }
            }
            catch (IOException error)
            {
                //  please provide better error diagnosis in real life!
                this.log("Error", "Can\'t read the file");
            }
        }
    }
}
