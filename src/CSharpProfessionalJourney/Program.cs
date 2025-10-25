using CSharpProfessionalJourney;

//1
var pointStruct = new PointStruct() {x = 5, y = 10};
var pointClass = new PointClass() { X = 2, Y = 14 };

//2
void ModifyStruct(PointStruct p)
{
    p.x = 7;
    p.y = 12;
}

void ModifyClass(PointClass p)
{
    p.X = 4;
    p.Y = 16;
}
Console.WriteLine("До изменений");
Console.WriteLine($"pointStruct: x={pointStruct.x}, y={pointStruct.y}");
Console.WriteLine($"ModifyClass: x={pointClass.X}, y={pointClass.Y}");

//3
ModifyStruct(pointStruct);
ModifyClass(pointClass);

Console.WriteLine("После изменений");
Console.WriteLine($"pointStruct: x={pointStruct.x}, y={pointStruct.y}");
Console.WriteLine($"ModifyClass: x={pointClass.X}, y={pointClass.Y}");

//4

void ModifyStructRef(ref PointStruct p)
{
    p.x = 66;
    p.y = 77;
}

ModifyStructRef(ref pointStruct);

Console.WriteLine("После изменений ref");
Console.WriteLine($"pointStruct: x={pointStruct.x}, y={pointStruct.y}");
Console.WriteLine($"ModifyClass: x={pointClass.X}, y={pointClass.Y}");
