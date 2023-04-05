using Microsoft.AspNetCore.Mvc.Testing;
using Question08.Api;
using System.Net.Http.Json;
using System.Text.Json;

namespace Question08.Tests;

public class ArtifactsTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> factory;

    public ArtifactsTest(WebApplicationFactory<Program> factory)
    {
        this.factory = factory.WithWebHostBuilder(_ => { });
    }

    [Fact]
    public async Task StartsEmpty()
    {
        var getResponse = await factory.CreateClient().GetAsync("requests");
        getResponse.EnsureSuccessStatusCode();

        var queueContent = await getResponse.Content.ReadAsStringAsync();
        AssertJsonEqual(Array.Empty<object>(), queueContent);
    }

    [Fact]
    public async Task PutThenGetAll()
    {
        await EnqueueRequest("John", "Doe", "New passport", 1);

        string json = await GetAllRequests();
        AssertJsonEqual(new[]
        {
            GetRequestJsonContent(1, "John", "Doe", "New passport")
        }, json);
    }

    [Fact]
    public async Task PutThenGetSingle()
    {
        await EnqueueRequest("John", "Doe", "New passport", 1);

        string json = await GetRequest(1);
        AssertJsonEqual(GetRequestJsonContent(1, "John", "Doe", "New passport"), json);
    }

    private async Task EnqueueRequest(string firstName, string lastName, string reason, int expectedId)
    {
        var putResponse = await factory.CreateClient().PostAsJsonAsync($"requests", new
        {
            firstName,
            lastName,
            reason
        });
        putResponse.EnsureSuccessStatusCode();

        var response = await putResponse.Content.ReadAsStringAsync();
        AssertJsonEqual(new { id = expectedId, firstName, lastName, reason }, response);
    }

    private static void AssertJsonEqual(object expectedContent, string actualJson)
    {
        Assert.Equal(JsonSerializer.Serialize(expectedContent), actualJson);
    }

    private static object GetRequestJsonContent(int id, string firstName, string lastName, string reason)
        => new { id, firstName, lastName, reason };

    private async Task<string> GetAllRequests()
    {
        var getResponse = await factory.CreateClient().GetAsync("requests");
        getResponse.EnsureSuccessStatusCode();

        return await getResponse.Content.ReadAsStringAsync();
    }

    private async Task<string> GetRequest(int id)
    {
        var getResponse = await factory.CreateClient().GetAsync($"requests/{id}");
        getResponse.EnsureSuccessStatusCode();

        return await getResponse.Content.ReadAsStringAsync();
    }

    [Fact]
    public async Task PutThreeAndGetAndGetAll()
    {
        await EnqueueRequest("John", "Doe", "New passport", 1);
        await EnqueueRequest("Jane", "Smith", "New ID card", 2);
        await EnqueueRequest("James", "Bond", "Name change", 3);

        AssertJsonEqual(GetRequestJsonContent(1, "John", "Doe", "New passport"), await GetRequest(1));
        AssertJsonEqual(GetRequestJsonContent(2, "Jane", "Smith", "New ID card"), await GetRequest(2));
        AssertJsonEqual(GetRequestJsonContent(3, "James", "Bond", "Name change"), await GetRequest(3));

        var requests = await GetAllRequests();
        AssertJsonEqual(new[]
        {
            GetRequestJsonContent(1, "John", "Doe", "New passport"),
            GetRequestJsonContent(2, "Jane", "Smith", "New ID card"),
            GetRequestJsonContent(3, "James", "Bond", "Name change")
        }, requests);
    }

}
