namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage2;

// ProductListSortType extended by order function delegate
public class ProductListSortType : Enumeration
{
    private readonly Func<IQueryable<Product>, IOrderedQueryable<Product>> _orderFunc;

    public static ProductListSortType BestMatch => new(0, "Best match",
        products => products.OrderBy(p => (p.PopularityScore + p.RatingScore) / 2));

    public static ProductListSortType RatingAscending =>
        new(10, "Rating", products => products.OrderBy(p => p.RatingScore));

    public static ProductListSortType RatingDescending => new(11, "Rating descending",
        products => products.OrderByDescending(p => p.RatingScore));

    public static ProductListSortType PriceAscending => new(20, "Price", products => products.OrderBy(p => p.Price));

    public static ProductListSortType PriceDescending =>
        new(21, "Price descending", products => products.OrderByDescending(p => p.Price));

    public static ProductListSortType PopularityAscending =>
        new(30, "Popularity", products => products.OrderBy(p => p.PopularityScore));

    public static ProductListSortType PopularityDescending => new(31, "Popularity descending",
        products => products.OrderByDescending(p => p.PopularityScore));

    protected ProductListSortType(int id, string name, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderFunc) : base(id, name)
    {
        _orderFunc = orderFunc;
    }

    public IOrderedQueryable<Product> OrderProductsQueryable(IQueryable<Product> products) => _orderFunc(products);
}