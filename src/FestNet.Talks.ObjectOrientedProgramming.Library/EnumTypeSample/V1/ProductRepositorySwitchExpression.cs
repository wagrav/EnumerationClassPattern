namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumTypeSample.V1;

public class ProductRepositorySwitchExpression
{
    private readonly IQueryable<Product> _products;

    public ProductRepositorySwitchExpression(IQueryable<Product> products)
    {
        _products = products;
    }

    public List<Product> GetSortedProductList(int pageIndex, int pageSize, ProductListSortType productListSortType)
    {
        var productsQuery = _products;

        productsQuery = productListSortType switch
        {
            ProductListSortType.BestMatch => productsQuery.OrderBy(p => (p.PopularityScore + p.RatingScore) / 2),
            ProductListSortType.RatingAscending => productsQuery.OrderBy(p => p.RatingScore),
            ProductListSortType.RatingDescending => productsQuery.OrderByDescending(p => p.RatingScore),
            ProductListSortType.PriceAscending => productsQuery.OrderBy(p => p.Price),
            ProductListSortType.PriceDescending => productsQuery.OrderByDescending(p => p.Price),
            ProductListSortType.PopularityAscending => productsQuery.OrderBy(p => p.PopularityScore),
            ProductListSortType.PopularityDescending => productsQuery.OrderByDescending(p => p.PopularityScore),
            _ => throw new ArgumentOutOfRangeException(nameof(productListSortType), productListSortType, null)
        };

        return productsQuery
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToList();
    }
}