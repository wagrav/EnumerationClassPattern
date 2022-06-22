namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

// To eliminate a Func Delegate introduced in Stage3, an inheritance and polymorphism can be used to increase
// readability and make solution even more opened and flexible for further requirements.
public abstract class ProductListSortType : Enumeration
{
    public static ProductListSortType BestMatch => ProductListBestMatchSortType.Instance; // or new ProductListRatingAscendingSortType(); depending on your preferences

    public static ProductListSortType RatingAscending => ProductListRatingAscendingSortType.Instance; // or new ProductListRatingAscendingSortType(); depending on your preferences

    public static ProductListSortType RatingDescending => new ProductListRatingDescendingSortType();

    public static ProductListSortType PriceAscending => new ProductListPriceAscendingSortType();

    public static ProductListSortType PriceDescending => new ProductListPriceDescendingSortType();

    public static ProductListSortType PopularityAscending => new ProductListPopularityAscendingSortType();

    public static ProductListSortType PopularityDescending => new ProductListPopularityDescendingSortType();

    protected ProductListSortType(int id, string name) : base(id, name)
    {
    }

    public abstract IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products);
}