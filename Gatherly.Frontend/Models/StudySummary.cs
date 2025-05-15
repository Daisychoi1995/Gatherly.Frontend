using System;

namespace Gatherly.Frontend.Models;

public class StudySummary
{
  public int Id { get; set; }

  public required string Title { get; set; }

  public required string Category { get; set; }

  public int MaxNumber { get; set; }

  public required string Place { get; set; }

  public required int UserId { get; set; }

  public DateTime Date { get; set; }

}
