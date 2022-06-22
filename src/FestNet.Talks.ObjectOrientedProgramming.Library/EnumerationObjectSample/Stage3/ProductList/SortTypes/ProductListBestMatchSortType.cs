namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

public class ProductListBestMatchSortType : ProductListSortType
{
    public static ProductListBestMatchSortType Instance => new(0, "Best match");

    protected ProductListBestMatchSortType(int id, string name) : base(id, name)
    {
    }

    public override IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products)
    {
        return products.OrderBy(p => (p.PopularityScore + p.RatingScore) / 2);
    }
}