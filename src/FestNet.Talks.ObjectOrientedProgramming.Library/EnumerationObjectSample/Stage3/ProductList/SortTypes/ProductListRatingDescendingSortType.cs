namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

public class ProductListRatingDescendingSortType : ProductListSortType
{
    public ProductListRatingDescendingSortType() : base(11, "Rating Descending")
    {
    }

    public override IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products)
    {
        return products.OrderByDescending(p => p.RatingScore);
    }
}