namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage3.ProductList.SortTypes;

public class ProductListPriceAscendingSortType : ProductListSortType
{
    public ProductListPriceAscendingSortType() : base(20, "Price Ascending")
    {
    }
    
    public override IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products)
    {
        return products.OrderByDescending(p => p.Price);
    }
}