using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace CanSatGroundStation
{
    public class Manager
    {
        public string Path = "log.txt";

        private MessageReceived messageReceivedDelagate;
        
        public Manager(Action<object[]> reciever)
        {
            messageReceivedDelagate = new MessageReceived(reciever);
        }

        public void writeToLog(object[] message)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(Path, true))
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        file.WriteLine(message[i]);
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing to file: \n" + e.Message);
            }
        }

        public List<object[]> readFromLog()
        {
            List<object[]> listObjectsArrays = new List<object[]>();
            try
            {
                using (StreamReader file = new StreamReader(Path))
                {
                    int current = 0;
                    object[] objectArray = new object[7];
                    while (!file.EndOfStream)
                    {
                        objectArray[current] = file.ReadLine();
                        current++;

                        if (current >= 7)
                        {
                            current = 0;
                            listObjectsArrays.Add(objectArray);
                            objectArray = new object[7];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file: \n" + e.Message);
            }

            return listObjectsArrays;
        }

        public void OpenLog()
        {
            Process.Start(Path);
        }

        public void ClearLog()
        {
            try
            {
                using (StreamWriter file = new StreamWriter(Path))
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error clearing file: \n" + e.Message);
            }

        }

        public void commitMessage(object[] message)
        {
            messageReceivedDelagate(message);
            writeToLog(message);
        }
    }
}

