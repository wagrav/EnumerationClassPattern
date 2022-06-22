// ReSharper disable PossibleUnintendedReferenceComparison
namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage1a;

public class ProductRepository
{
    private readonly IQueryable<Product> _products;

    public ProductRepository(IQueryable<Product> products)
    {
        _products = products;
    }

    public List<Product> GetSortedProductList(int pageIndex, int pageSize, ProductListSortType productListSortType)
    {
        IQueryable<Product> productsQuery = _products;
        
        if (productListSortType == ProductListSortType.BestMatch)
        {
            productsQuery = productsQuery.OrderBy(p => (p.PopularityScore + p.RatingScore) / 2);
        }
        else if (productListSortType == ProductListSortType.RatingAscending)
        {
            productsQuery = productsQuery.OrderBy(p => p.RatingScore);
        }
        else if (productListSortType == ProductListSortType.RatingDescending)
        {
            productsQuery = productsQuery.OrderByDescending(p => p.RatingScore);
        }
        else if (productListSortType == ProductListSortType.PriceAscending)
        {
            productsQuery = productsQuery.OrderBy(p => p.Price);
        }
        else if (productListSortType == ProductListSortType.PriceDescending)
        {
            productsQuery = productsQuery.OrderByDescending(p => p.Price);
        }
        else if (productListSortType == ProductListSortType.PopularityAscending)
        {
            productsQuery = productsQuery.OrderBy(p => p.PopularityScore);
        }
        else if (productListSortType == ProductListSortType.PopularityDescending)
        {
            productsQuery = productsQuery.OrderByDescending(p => p.PopularityScore);
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(productListSortType), productListSortType, null);
        }

        return productsQuery
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public List<Product> GetSortedProductListEquals(int pageIndex, int pageSize, ProductListSortType productListSortType)
    {
        IQueryable<Product> productsQuery = _products;

        if (productListSortType.Equals(ProductListSortType.BestMatch))
        {
            productsQuery = productsQuery.OrderBy(p => (p.PopularityScore + p.RatingScore) / 2);
        }
        else if (productListSortType.Equals(ProductListSortType.RatingAscending))
        {
            productsQuery = productsQuery.OrderBy(p => p.RatingScore);
        }
        else if (productListSortType.Equals(ProductListSortType.RatingDescending))
        {
            productsQuery = productsQuery.OrderByDescending(p => p.RatingScore);
        }
        else if (productListSortType.Equals(ProductListSortType.PriceAscending))
        {
            productsQuery = productsQuery.OrderBy(p => p.Price);
        }
        else if (productListSortType.Equals(ProductListSortType.PriceDescending))
        {
            productsQuery = productsQuery.OrderByDescending(p => p.Price);
        }
        else if (productListSortType.Equals(ProductListSortType.PopularityAscending))
        {
            productsQuery = productsQuery.OrderBy(p => p.PopularityScore);
        }
        else if (productListSortType.Equals(ProductListSortType.PopularityDescending))
        {
            productsQuery = productsQuery.OrderByDescending(p => p.PopularityScore);
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(productListSortType), productListSortType, null);
        }

        return productsQuery
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToList();
    }
}