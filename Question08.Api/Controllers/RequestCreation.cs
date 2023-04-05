namespace Question08.Api.Repositories;

public record RequestCreation(string FirstName, string LastName, string Reason)
{
    public Request Create(int id)
        => new Request(id, FirstName, LastName, Reason);
}
