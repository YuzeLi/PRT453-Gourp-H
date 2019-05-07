using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_RemoveDuplication
{
    public abstract class Duplications
    {
        public abstract void saveFile(String filename, String fileContent);
        public abstract String readFile(String filename);
        public abstract void log(String level, String message);

        // boiler plate code
        private void ExecuteWithNiceLogging(Closure algorithm, String errorMessage)
        {
            try
            {
                algorithm.call();
            }
            catch (IOException error)
            {
                // please provide better error diagnosis in real life!
                log("Error", errorMessage);
            }
        }

        // code interesting to business
        public void createFile()
        {
            saveGreetings("Beyond Java says \"Hello World!\"");
        }
        // code interesting to business
        private void saveGreetings(String fileContents)
        {
           executeWithNiceLogging(saveFile("Greetings.txt", fileContents), "Can't write the file due to an exception");
        }


        // code interesting to business
        public void copyFile()
        {
            executeWithNiceLogging({ saveGreetings(readFile("OldFileName.txt")) }, "Can't read the file")
        }
    }
}
