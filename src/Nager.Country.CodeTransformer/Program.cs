using System.IO;

namespace Nager.Country.CodeTransformer
{
    static class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"..\..\..\..\Nager.Country.Translation\CountryTranslations\");
            foreach (var file in files)
            {
                //RemoveFileBlock(file, "ingCodes", 0, "};", 9);
                //RenameClassFile(file);
            }
        }

        static void RenameClassFile(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            var fileContent = File.ReadAllText(filePath);

            var newFileName = fileNameWithoutExtension.Replace("Info", "CountryTranslation");
            var newContent = fileContent.Replace(fileNameWithoutExtension, newFileName);

            File.WriteAllText($"{Path.Combine(fileInfo.Directory.FullName, newFileName)}.cs", newContent);
            File.Delete(filePath);
        }

        static void RemoveFileBlock(string filePath, string searchValue1, int startPositionShift, string searchValue2, int endPositionShift)
        {
            var fileContent = File.ReadAllText(filePath);
            var startPosition = fileContent.IndexOf(searchValue1);
            if (startPosition != -1)
            {
                startPosition += startPositionShift;

                var endPosition = fileContent.IndexOf(searchValue2, startPosition);
                var part1 = fileContent.Substring(0, startPosition);
                var part2 = fileContent.Substring(endPosition + endPositionShift);

                var newFileContent = $"{part1}{part2}";
                File.WriteAllText(filePath, newFileContent);
            }
        }
    }
}
