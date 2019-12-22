namespace PostAway.Helpers
{
  public class PostAwayDatabaseSettings : IPostAwayDatabaseSettings
  {
    public string PostsCollectionName { get; set; }
    public string UsersCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

  public interface IPostAwayDatabaseSettings
  {
    string PostsCollectionName { get; set; }
    string UsersCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}