using Application.Abstractions.Storage;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Storage;

internal sealed class StorageService : IStorageService
{
    private readonly string _storagePath;

    public StorageService()
    {
        _storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
        if (!Directory.Exists(_storagePath))
        {
            Directory.CreateDirectory(_storagePath);
        }
    }

    public async Task<Guid> UploadAsync(Stream stream, string contentType, CancellationToken cancellationToken = default)
    {
        if (stream == null || stream.Length == 0)
        {
            throw new ArgumentException("File stream cannot be null or empty", nameof(stream));
        }

        var fileId = Guid.NewGuid();
        var fileExtension = GetFileExtensionFromContentType(contentType);
        var filePath = Path.Combine(_storagePath, $"{fileId}{fileExtension}");

        await SaveToFileAsync(stream, filePath, cancellationToken);

        return fileId;
    }

    public async Task DeleteAsync(Guid fileId, CancellationToken cancellationToken = default)
    {
        var filePath = Path.Combine(_storagePath, $"{fileId}");

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        else
        {
            throw new FileNotFoundException("File not found", filePath);
        }

        await Task.CompletedTask;
    }

    private async Task SaveToFileAsync(Stream stream, string filePath, CancellationToken cancellationToken)
    {
        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            await stream.CopyToAsync(fileStream, cancellationToken);
        }
    }

    private string GetFileExtensionFromContentType(string contentType)
    {
        return contentType switch
        {
            "image/jpeg" => ".jpg",
            "image/png" => ".png",
            "image/gif" => ".gif",
            "application/pdf" => ".pdf",
            "text/plain" => ".txt",
            _ => ".bin",
        };
    }
}