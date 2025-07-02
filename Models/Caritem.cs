using System;

namespace TodoList.Models; // กำหนด namespace เพื่อจัดกลุ่มคลาสภายใต้โปรเจกต์ TodoList

public class Caritem
{
    public int Id { get; set; } // รหัสเฉพาะของรถแต่ละรายการ
    public string? Type { get; set; } // ประเภทรถ
    public int Quantity { get; set; } // จำนวนของรถประเภทนั้น
    public bool IsActive { get; set; } = true;
    public DateTime CreatedDate { get; set; } = DateTime.Now; // วันที่สร้างรายการ
    public DateTime? LastModified { get; set; } // วันที่ที่มีการแก้ไขล่าสุด

}
