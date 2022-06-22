namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage1b;

// ProductListSortType extended by Description Property
public class ProductListSortType : Enumeration
{
    public static ProductListSortType BestMatch => new(0, "Best match", "Let us find your best matches.");

    public static ProductListSortType RatingAscending => new(10, "Rating", "Products are ordered ascending by users rating.");

    public static ProductListSortType RatingDescending => new(11, "Rating descending", "Products are ordered descending by users rating.");

    public static ProductListSortType PriceAscending => new(20, "Price", "Products are ordered ascending by price.");

    public static ProductListSortType PriceDescending => new(21, "Price descending", "Products are ordered descending by price.");

    public static ProductListSortType PopularityAscending => new(30, "Popularity", "Products are ascending descending by their popularity in our service.");

    public static ProductListSortType PopularityDescending => new(31, "Popularity descending", "Products are ordered descending by their popularity in our service.");

    public string Description { get; }

    protected ProductListSortType(int id, string name, string description) : base(id, name)
    {
        this.Description = description;
    }
}