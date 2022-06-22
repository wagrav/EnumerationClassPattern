namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

public class ProductListPriceDescendingSortType : ProductListSortType
{
    public ProductListPriceDescendingSortType() : base(21, "Price Descending")
    {
    }

    public override IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products)
    {
        return products.OrderByDescending(p => p.Price);
    }
}