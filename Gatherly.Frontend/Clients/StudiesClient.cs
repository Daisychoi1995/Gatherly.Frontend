using System;
using Gatherly.Frontend.Models;

namespace Gatherly.Frontend.Clients;

public class StudiesClient(HttpClient httpClient)
{
  public async Task<StudySummary[]> GetStudiesAsync() => await httpClient.GetFromJsonAsync<StudySummary[]>("studies") ?? [];
}
