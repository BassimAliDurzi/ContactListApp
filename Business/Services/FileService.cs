using Business.Interfaces;

namespace Business.Services;

public class FileService(string basePath, string fileName) : IFileService
{
    private readonly string _directoryPath = Path.Combine(basePath, "Data");
    private readonly string _filePath = Path.Combine(basePath, fileName);

    public string GetContentFromFile()
    {
        if (File.Exists(_filePath))
        {
            return File.ReadAllText(_filePath);
        }
        return null!;
    }

    public bool SaveContentToFile(string content)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            File.WriteAllText(_filePath, content);
            return true;
        }
        catch
        {
            return false;
        }
    }


}