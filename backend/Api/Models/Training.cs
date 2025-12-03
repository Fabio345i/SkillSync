using System;
namespace backend.Api.Models;

public class Training
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}
