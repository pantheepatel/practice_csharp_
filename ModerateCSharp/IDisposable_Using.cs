using System;
using System.IO;

class FileHandler : IDisposable
{
    private FileStream _fileStream;

    public FileHandler(string filePath)
    {
        _fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        Console.WriteLine("File opened.");
    }

    public void Dispose()
    {
        if (_fileStream != null)
        {
            _fileStream.Close();
            _fileStream.Dispose();
            Console.WriteLine("File closed.");
        }
    }
}