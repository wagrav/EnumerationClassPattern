namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

public class ProductListPopularityDescendingSortType : ProductListSortType
{
    public ProductListPopularityDescendingSortType() : base(31, "Popularity Descending")
    {
    }

    public override IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products)
    {
        return products.OrderByDescending(p => p.PopularityScore);
    }
}