using Microsoft.AspNetCore.Http;

namespace Application.Abstractions.Storage;

public interface IFileService
{
    public Task<string> UploadImageAsync(IFormFile image);

    public Task<bool> DeleteImageAsync(string subpath);
}
