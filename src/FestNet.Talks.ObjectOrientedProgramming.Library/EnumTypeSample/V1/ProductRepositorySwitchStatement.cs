namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumTypeSample.V1;

public class ProductRepositorySwitchStatement
{
    private readonly IQueryable<Product> _products;

    public ProductRepositorySwitchStatement(IQueryable<Product> products)
    {
        _products = products;
    }

    public List<Product> GetSortedProductList(int pageIndex, int pageSize, ProductListSortType productListSortType)
    {
        var productsQuery = _products;
        
        switch (productListSortType)
        {
            case ProductListSortType.BestMatch:
                productsQuery = productsQuery.OrderBy(p => (p.PopularityScore + p.RatingScore) / 2);
                break;
            case ProductListSortType.RatingAscending:
                productsQuery = productsQuery.OrderBy(p => p.RatingScore);
                break;
            case ProductListSortType.RatingDescending:
                productsQuery = productsQuery.OrderByDescending(p => p.RatingScore);
                break;
            case ProductListSortType.PriceAscending:
                productsQuery = productsQuery.OrderBy(p => p.Price);
                break;
            case ProductListSortType.PriceDescending:
                productsQuery = productsQuery.OrderByDescending(p => p.Price);
                break;
            case ProductListSortType.PopularityAscending:
                productsQuery = productsQuery.OrderBy(p => p.PopularityScore);
                break;
            case ProductListSortType.PopularityDescending:
                productsQuery = productsQuery.OrderByDescending(p => p.PopularityScore);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(productListSortType), productListSortType, null);
        }

        return productsQuery
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToList();
    }
}