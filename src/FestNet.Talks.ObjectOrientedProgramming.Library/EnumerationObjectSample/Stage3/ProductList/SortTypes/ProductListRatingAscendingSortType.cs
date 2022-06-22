namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

public class ProductListRatingAscendingSortType : ProductListSortType
{
    public static ProductListRatingAscendingSortType Instance => new(10, "Rating Ascending");

    public ProductListRatingAscendingSortType() : this(10, "Rating Ascending")
    {
    }

    protected ProductListRatingAscendingSortType(int id, string name) : base(id, name)
    {
    }

    public override IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products)
    {
        return products.OrderBy(p => p.RatingScore);
    }
}