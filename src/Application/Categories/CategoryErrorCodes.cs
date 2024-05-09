namespace Application.Categories;

public static class CategoryErrorCodes
{
    public const string MissingCategoryId = nameof(MissingCategoryId);
    public const string MissingCategoryName = nameof(MissingCategoryName);

    public static class DeleteCategory
    {
        public const string MissingCategoryId = nameof(MissingCategoryId);
    }
}
