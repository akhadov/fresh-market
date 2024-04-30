namespace Domain.Categories;

public interface ICategoryRepository
{
    bool CategoryExists(string categoryName);
}
