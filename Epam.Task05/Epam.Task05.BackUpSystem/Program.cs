using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Epam.Task05.BackUpSystem
{
    public class Program
    {
        public const string FileFilter = "*.txt";
        public const string BAKFilter = "*.bak";
        public const string FirstBAK = "0.bak";
        public const string BAKextension = ".bak";
        public const string LogFile = "Backup.log";

        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            string input;
            string inputData;
            bool correctInput = false;
            do
            {
                Console.WriteLine("Print w to watch current directory, print r to restore files");
                input = Console.ReadLine();

                if ((input.ToLower() != "r") || (input.ToLower() != "w"))
                {
                    correctInput = true;
                }
            }
            while (!correctInput);

            if (input.ToLower() == "w")
            {
                FileSystemWatcher watch = new FileSystemWatcher(Directory.GetCurrentDirectory(), FileFilter);

                string logpath = Directory.GetCurrentDirectory() + "\\" + "Backup";
                string fullNameLogFile = logpath + "\\" + LogFile;

                if (!Directory.Exists(logpath))
                {
                    Directory.CreateDirectory(logpath);
                }

                if (!File.Exists(fullNameLogFile))
                {
                    using (StreamWriter log = File.CreateText(fullNameLogFile))
                    {
                    }
                }

                SaveFiles(Directory.GetCurrentDirectory());

                watch.Created += new FileSystemEventHandler(FileCreated);
                watch.Deleted += new FileSystemEventHandler(FileDeleted);
                watch.Renamed += new RenamedEventHandler(FileRenamed);

                watch.EnableRaisingEvents = true;

                do
                {
                    Console.WriteLine("Print e for exit");
                }
                while (Console.Read() != 'e');
            }
            else
            {
                DateTime time;
                bool dataConverted;

                do
                {
                    Console.WriteLine("Print desired time to restore files, for example 25.12.2018 17:16:33");
                    inputData = Console.ReadLine();
                    dataConverted = DateTime.TryParse(inputData, out time);

                    if (!dataConverted)
                    {
                        Console.WriteLine("Unable to parse input data");
                    }
                }
                while (!dataConverted);

                RestoreFiles(Directory.GetCurrentDirectory(), time);

                Console.WriteLine("Files restored");
            }
        }

        public static void FileCreated(object sender, FileSystemEventArgs e)
        {
            string fullNameLogFile = Directory.GetCurrentDirectory() + "\\" + "Backup" + "\\" + LogFile;
            string curDir = Directory.GetCurrentDirectory();
            try
            {
                using (StreamWriter log = new StreamWriter(fullNameLogFile, true))
                {
                    bool fileInIds = false;

                    FileInfo file = new FileInfo(e.FullPath);
                    
                    IEnumerable<string> textFileIDs = Directory.EnumerateFiles(curDir + "\\" + "Backup", BAKFilter);

                    foreach (string currentId in textFileIDs)
                    {
                        FileInfo fileId = new FileInfo(currentId);

                        if (IsEqual(file.FullName, fileId.FullName))
                        {
                            fileInIds = true;
                            log.WriteLine("{0}|{1}|{2}|{3}", file.Name, file.CreationTime.ToString(), file.FullName, fileId.FullName);
                            break;
                        }
                    }

                    if (!fileInIds)
                    {
                        FileInfo fileIdLastOld = new FileInfo(textFileIDs.Last());

                        if (int.TryParse(fileIdLastOld.Name.Remove(fileIdLastOld.Name.Length - 4), out int fileIdLast))
                        {
                            fileIdLast++;
                            string fileIdNew = fileIdLast.ToString() + BAKextension;

                            file.CopyTo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                            FileInfo fileId = new FileInfo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                            log.WriteLine("{0}|{1}|{2}|{3}", file.Name, file.CreationTime.ToString(), file.FullName, fileId.FullName);
                        }
                        else
                        {
                            Console.WriteLine($"File ID {textFileIDs.Last()} name error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            string fullNameLogFile = Directory.GetCurrentDirectory() + "\\" + "Backup" + "\\" + LogFile;
            string curDir = Directory.GetCurrentDirectory();

            FileInfo file = new FileInfo(e.FullPath);

            try
            {
                using (StreamWriter log = new StreamWriter(fullNameLogFile, true))
                {
                    bool fileInIds = false;

                    IEnumerable<string> textFileIDs = Directory.EnumerateFiles(curDir + "\\" + "Backup", BAKFilter);

                    foreach (string currentId in textFileIDs)
                    {
                        FileInfo fileId = new FileInfo(currentId);

                        if (IsEqual(file.FullName, fileId.FullName))
                        {
                            fileInIds = true;
                            log.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", file.Name, file.CreationTime.ToString(), file.FullName, fileId.FullName, "D", DateTime.Now.ToString());
                            break;
                        }
                    }

                    if (!fileInIds)
                    {
                        FileInfo fileIdLastOld = new FileInfo(textFileIDs.Last());

                        if (int.TryParse(fileIdLastOld.Name.Remove(fileIdLastOld.Name.Length - 4), out int fileIdLast))
                        {
                            fileIdLast++;
                            string fileIdNew = fileIdLast.ToString() + BAKextension;

                            file.CopyTo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                            FileInfo fileId = new FileInfo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                            log.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", file.Name, file.CreationTime.ToString(), file.FullName, fileId.FullName, "D", DateTime.Now.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"File ID {textFileIDs.Last()} name error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void FileRenamed(object sender, RenamedEventArgs e)
        {
            string fullNameLogFile = Directory.GetCurrentDirectory() + "\\" + "Backup" + "\\" + LogFile;
            string curDir = Directory.GetCurrentDirectory();

            FileInfo file = new FileInfo(e.FullPath);

            try
            {
                using (StreamWriter log = new StreamWriter(fullNameLogFile, true))
                {
                    bool fileInIds = false;

                    IEnumerable<string> textFileIDs = Directory.EnumerateFiles(curDir + "\\" + "Backup", BAKFilter);

                    foreach (string currentId in textFileIDs)
                    {
                        FileInfo fileId = new FileInfo(currentId);

                        if (IsEqual(file.FullName, fileId.FullName))
                        {
                            fileInIds = true;
                            log.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", e.OldName, file.CreationTime.ToString(), e.OldFullPath, fileId.FullName, "R", file.FullName, DateTime.Now.ToString());
                            break;
                        }
                    }

                    if (!fileInIds)
                    {
                        FileInfo fileIdLastOld = new FileInfo(textFileIDs.Last());

                        if (int.TryParse(fileIdLastOld.Name.Remove(fileIdLastOld.Name.Length - 4), out int fileIdLast))
                        {
                            fileIdLast++;
                            string fileIdNew = fileIdLast.ToString() + BAKextension;

                            file.CopyTo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                            FileInfo fileId = new FileInfo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                            log.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", e.OldName, file.CreationTime.ToString(), e.OldFullPath, fileId.FullName, "R", file.FullName, DateTime.Now.ToString());
                        }
                        else
                        {
                            Console.WriteLine($"File ID {textFileIDs.Last()} name error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SaveFiles(string curDir)
        {
            IEnumerable<string> textFiles = Directory.EnumerateFiles(curDir, FileFilter);

            if (textFiles.Count() != 0)
            {
                IEnumerable<string> idFiles = Directory.EnumerateFiles(Directory.GetCurrentDirectory() + "\\" + "Backup", BAKFilter);

                if (!idFiles.Contains(curDir + "\\" + "Backup" + "\\" + FirstBAK))
                {
                    FileInfo id = new FileInfo(textFiles.First());

                    id.CopyTo(curDir + "\\" + "Backup" + "\\" + FirstBAK);
                }

                string fullNameLogFile = Directory.GetCurrentDirectory() + "\\" + "Backup" + "\\" + LogFile;

                using (StreamWriter log = new StreamWriter(fullNameLogFile, true))
                {
                    foreach (string currentFile in textFiles)
                    {
                        bool fileInIDs = false;

                        FileInfo fileInDir = new FileInfo(currentFile);

                        IEnumerable<string> textFileIDs = Directory.EnumerateFiles(curDir + "\\" + "Backup", BAKFilter);

                        foreach (string currentId in textFileIDs)
                        {
                            FileInfo fileId = new FileInfo(currentId);

                            if (IsEqual(fileInDir.FullName, fileId.FullName))
                            {
                                fileInIDs = true;
                                log.WriteLine("{0}|{1}|{2}|{3}", fileInDir.Name, fileInDir.CreationTime.ToString(), fileInDir.FullName, fileId.FullName);
                                break;
                            }
                        }

                        if (!fileInIDs)
                        {
                            FileInfo fileIdLastOld = new FileInfo(textFileIDs.Last());

                            if (int.TryParse(fileIdLastOld.Name.Remove(fileIdLastOld.Name.Length - 4), out int fileIdLast))
                            {
                                fileIdLast++;
                                string fileIdNew = fileIdLast.ToString() + BAKextension;

                                fileInDir.CopyTo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                                FileInfo fileId = new FileInfo(curDir + "\\" + "Backup" + "\\" + fileIdNew);

                                log.WriteLine("{0}|{1}|{2}|{3}", fileInDir.Name, fileInDir.CreationTime.ToString(), fileInDir.FullName, fileId.FullName);
                            }
                            else
                            {
                                Console.WriteLine($"File ID {textFileIDs.Last()} name error");
                            }
                        }
                    }
                }
            }
        }

        public static void RestoreFiles(string curDir, DateTime time)
        {
            IEnumerable<string> textFiles = Directory.EnumerateFiles(curDir, FileFilter);

            foreach (string file in textFiles)
            {
                FileInfo textFile = new FileInfo(file);
                textFile.Delete();
            }

            string fullNameLogFile = Directory.GetCurrentDirectory() + "\\" + "Backup" + "\\" + LogFile;

            using (StreamReader log = new StreamReader(fullNameLogFile))
            {
                while (!log.EndOfStream)
                {
                    string[] filename = log.ReadLine().Split(new char[] { '|' });

                    if (!DateTime.TryParse(filename[1], out DateTime fileTime))
                    {
                        Console.WriteLine($"Invalid date format in logfile {filename[0]}");
                    }
                    else if (time >= fileTime)
                    {
                        if (filename.Length > 4 && filename[4] == "R")
                        {
                            int i = 4;
                            DateTime renamedTime;
                            do
                            {
                                if (DateTime.TryParse(filename[i + 2], out renamedTime))
                                {
                                    if (time >= renamedTime)
                                    {
                                        FileInfo restored = new FileInfo(filename[3]);

                                        restored.CopyTo(filename[i + 1]);

                                        File.SetCreationTime(filename[i + 1], fileTime);
                                        File.SetLastWriteTime(filename[i + 1], fileTime);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid renamed date format in logfile { filename[0]}");
                                }

                                i += 3;
                            }
                            while (i + 3 < filename.Length);
                        }
                        else
                        {
                            FileInfo restored = new FileInfo(filename[3]);

                            restored.CopyTo(filename[2]);

                            File.SetCreationTime(filename[2], fileTime);
                            File.SetLastWriteTime(filename[2], fileTime);
                        }
                    }
                }
            }
        }

        public static bool IsEqual(string fullPathFile1, string fullPathFile2)
        {
            string text1;
            string text2;

            using (StreamReader textfile1 = new StreamReader(fullPathFile1, System.Text.Encoding.Default))
            {
                text1 = textfile1.ReadToEnd();
            }

            using (StreamReader textfile2 = new StreamReader(fullPathFile2, System.Text.Encoding.Default))
            {
                text2 = textfile2.ReadToEnd();
            }

            if (text1 == text2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
