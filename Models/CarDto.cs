using System;

namespace TodoList.Models;

public class CarDto
{
    public int Id { get; set; } // รหัสเฉพาะของรถแต่ละรายการ
    public string? Type { get; set; } // ประเภทรถ
    public int Quantity { get; set; } // จำนวนของรถประเภทนั้น
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public DateTime CreateAt { get; set; }

}
