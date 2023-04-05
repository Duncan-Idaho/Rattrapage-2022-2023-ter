namespace Question08.Api.Repositories
{
    public class RequestsRepository
    {
        readonly Dictionary<int, Request> requests = new();

        public IEnumerable<Request> GetAll()
            => requests.Values;

        public Request? Get(int id)
            => requests.TryGetValue(id, out var result)
            ? result
            : null;

        public Request Save(Request request)
            => requests[request.Id] = request;

        public int NextId => requests.Count + 1;
    }
}
