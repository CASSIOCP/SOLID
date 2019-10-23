using System.IO;

namespace Solid.Single_Responsibility
{
    public static class FileSaver
    {
        public static void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> entries)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), entries.ToString());
        }
    }
}