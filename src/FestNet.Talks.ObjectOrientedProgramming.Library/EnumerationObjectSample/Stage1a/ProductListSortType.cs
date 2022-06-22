namespace FestNet.Talks.ObjectOrientedProgramming.Library.EnumerationObjectSample.Stage1a;

public class ProductListSortType : Enumeration
{
    public static ProductListSortType BestMatch => new(0, "Best match");
    public static ProductListSortType RatingAscending => new(10, "Rating");
    public static ProductListSortType RatingDescending => new(11, "Rating descending");
    public static ProductListSortType PriceAscending => new(20, "Price");
    public static ProductListSortType PriceDescending => new(21, "Price descending");
    public static ProductListSortType PopularityAscending => new(30, "Popularity");
    public static ProductListSortType PopularityDescending => new(31, "Popularity descending");

    protected ProductListSortType(int id, string name) : base(id, name)
    {
    }
}