namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

public class ProductListPopularityAscendingSortType : ProductListSortType
{
    public ProductListPopularityAscendingSortType() : base(30, "Popularity Ascending")
    {
    }

    public override IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products)
    {
        return products.OrderByDescending(p => p.PopularityScore);
    }
}