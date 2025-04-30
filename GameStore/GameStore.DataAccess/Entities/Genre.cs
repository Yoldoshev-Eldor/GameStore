namespace GameStore.DataAccess.Entities;

public class Genre
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid ParentGenreId { get; set; }

}
