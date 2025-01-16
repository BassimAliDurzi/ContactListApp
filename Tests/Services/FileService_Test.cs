using Business.Interfaces;
using Business.Services;

namespace Tests.Services;

public class FileService_Test
{
    [Fact]
    public void SaveContentToFile_ShouldSaveContentToFile()
    {
        // arrang
        var content = "test";
        var basePath = @"c:\projects\";
        var fileName = @$"{Guid.NewGuid()}.json";
       
        IFileService fileService = new FileService(basePath, fileName);

        try 
        {
            // act

            var result = fileService.SaveContentToFile(content);

            // assert
            Assert.True(result);
        }
        finally
        {
            if(File.Exists(fileName))
                File.Delete(fileName); 
        }
    }

    [Fact]
    public void GetContentFromFile_ShouldReturnContentFromFile()
    {

        // arrang
        var content = "test";
        var basePath = @"c:\projects\";
        var fileName = @$"{Guid.NewGuid()}.json";

        File.WriteAllText(Path.Combine(basePath, fileName), content);
        IFileService fileService = new FileService(basePath, fileName);

        try
        {
            // act

            var result = fileService.GetContentFromFile();

            // assert
            Assert.Equal(content, result);
        }
        finally
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
        }
    }



}
