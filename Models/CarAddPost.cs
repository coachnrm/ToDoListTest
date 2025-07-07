using System;

namespace TodoList.Models;

public class CarAddPost
{
    public int Id { get; set; }
    public string? Type { get; set; } = "";
    public int Quantity { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public DateTime CreateAt { get; set; }

}
