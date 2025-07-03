using System;

namespace TodoList.Models; // กำหนด namespace เพื่อจัดกลุ่มคลาสภายใต้โปรเจกต์ TodoList

public class Caritem
{
    //public int Id { get; set; } // รหัสเฉพาะของรถแต่ละรายการ
    public string? Type { get; set; } // ประเภทรถ
    public int Quantity { get; set; } // จำนวนของรถประเภทนั้น
    

}
