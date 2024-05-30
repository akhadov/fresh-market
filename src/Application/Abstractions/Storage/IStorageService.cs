using Microsoft.AspNetCore.Http;

namespace Application.Abstractions.Storage;

public interface IStorageService
{
    //Task<Guid> UploadAsync(Stream stream, string contentType, CancellationToken cancellationToken = default);
    //Task<Guid> UploadAsync(IFormFile file, CancellationToken cancellationToken = default);
    Task<string> UploadAsync(IFormFile file, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid fileId, CancellationToken cancellationToken = default);
}
