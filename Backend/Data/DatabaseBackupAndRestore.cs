using System;
using System.Diagnostics;
using System.IO;

namespace DatabaseBackupAndRestore
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please specify an operation: backup or restore.");
                return;
            }

            switch (args[0].ToLower())
            {
                case "backup":
                    PerformBackup();
                    break;
                case "restore":
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Please specify the backup file path for restoration.");
                        return;
                    }
                    PerformRestore(args[1]);
                    break;
                default:
                    Console.WriteLine("Invalid operation. Supported operations: backup, restore.");
                    break;
            }
        }

        private static void PerformBackup()
        {
            /// Define backup parameters
            string host = "localhost"; // PostgreSQL server host
            string port = "5432"; // PostgreSQL server port
            string username = "your_username"; // PostgreSQL user
            string backupDirectory = @"path\to\backup\directory"; // Directory where backups will be stored
            string backupFileName = $"db_backup_{DateTime.Now:yyyyMMdd_HHmmss}.sql"; // Backup file name with current date-time

            string fullPath = Path.Combine(backupDirectory, backupFileName);
            
            // Prepare the pg_dumpall command
            string cmd = "pg_dumpall";
            string cmdArgs = $"-h {host} -p {port} -U {username} -f {fullPath}";

            // Execute the command
            Process process = new Process();
            process.StartInfo.FileName = cmd;
            process.StartInfo.Arguments = cmdArgs;
            process.StartInfo.RedirectStandardInput = true; // To allow entering password
            process.StartInfo.UseShellExecute = false; // Required for redirecting input/output
            process.Start();

            // You might need to enter the password unless you're using a .pgpass file or another method
            // process.StandardInput.WriteLine("your_password");

            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                Console.WriteLine($"Backup completed successfully. Saved to {fullPath}.");
            }
            else
            {
                Console.WriteLine("Backup failed.");
            }
        }

        private static void PerformRestore(string backupFilePath)
        {
            if (!File.Exists(backupFilePath))
            {
                Console.WriteLine($"Backup file not found: {backupFilePath}");
                return;
            }

            string host = "localhost";
            string port = "5432";
            string dbName = "your_database_name";
            string username = "your_username";

            string cmd = "psql";
            string cmdArgs = $"-h {host} -p {port} -U {username} -d {dbName} -f {backupFilePath}";

            Process process = new Process();
            process.StartInfo.FileName = cmd;
            process.StartInfo.Arguments = cmdArgs;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;

            process.Start();

            // If password is needed
            // process.StandardInput.WriteLine("your_password");

            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                Console.WriteLine($"Database restored successfully from {backupFilePath}.");
            }
            else
            {
                Console.WriteLine("Restore failed.");
            }
        }
    }
}
