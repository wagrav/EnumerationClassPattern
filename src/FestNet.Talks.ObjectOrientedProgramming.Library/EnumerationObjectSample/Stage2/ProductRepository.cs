namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage2;

public class ProductRepository
{
    private readonly IQueryable<Product> _products;

    public ProductRepository(IQueryable<Product> products)
    {
        _products = products;
    }

    public List<Product> GetSortedProductList(int pageIndex, int pageSize, ProductListSortType productListSortType)
    {
        var productsQuery = _products;

        productsQuery = productListSortType.OrderProductsQueryable(productsQuery);
        
        return productsQuery
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public List<Product> GetSortedProductList(int pageIndex, int pageSize, string productListSortTypeName)
    {
        var productsQuery = _products;

        productsQuery = Enumeration
            .FromDisplayName<ProductListSortType>(productListSortTypeName)
            .OrderProductsQueryable(productsQuery);

        return productsQuery
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public List<Product> GetSortedProductList(int pageIndex, int pageSize, int sortTypeId)
    {
        var productsQuery = _products;

        productsQuery = Enumeration
            .FromValue<ProductListSortType>(sortTypeId)
            .OrderProductsQueryable(productsQuery);

        return productsQuery
            .Skip(pageIndex * pageSize)
            .Take(pageSize)
            .ToList();
    }
}