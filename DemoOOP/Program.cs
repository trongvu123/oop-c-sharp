using DemoOOP;

List<Employee> employees = new List<Employee>();
while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Thêm nhân viên");
    Console.WriteLine("2. Tìm nhân viên có lương cao nhất");
    Console.WriteLine("3. Tìm nhân viên theo tên");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn một lựa chọn: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddEmployee(employees);
            break;
        case 2:
            FindHighestSalaryEmployee(employees);
            break;
        case 3:
            FindEmployeeByName(employees);
            break;
        case 4:
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
            break;
    }
}

   static void AddEmployee(List<Employee> employees)
{
    Console.Write("Nhập loại nhân viên (1 - FullTime, 2 - PartTime): ");
    int type = int.Parse(Console.ReadLine());

    Console.Write("Nhập tên: ");
    string name = Console.ReadLine();

    Console.Write("Nhập tiền lương mỗi giờ: ");
    int paymentPerHour = int.Parse(Console.ReadLine());

    try
    {
        if (type == 1)
        {
            employees.Add(new FullTimeEmploee(name, paymentPerHour));
        }
        else if (type == 2)
        {
            Console.Write("Nhập số giờ làm việc: ");
            int workingHours = int.Parse(Console.ReadLine());
            employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
        }
        else
        {
            Console.WriteLine("Loại nhân viên không hợp lệ.");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Dữ liệu nhập không hợp lệ: " + e.Message);
    }
}
static void FindHighestSalaryEmployee(List<Employee> employees)
{
    if (employees.Count == 0)
    {
        Console.WriteLine("Không có nhân viên nào trong danh sách.");
        return;
    }

    var highestSalaryEmployee = employees.OrderByDescending(e => e.calculateSalary()).FirstOrDefault();

    if (highestSalaryEmployee != null)
    {
        Console.WriteLine($"Nhân viên có lương cao nhất: {highestSalaryEmployee}");
        
    }
    else
    {
        Console.WriteLine("Không tìm thấy nhân viên.");
    }
}
static void FindEmployeeByName(List<Employee> employees)
{
    Console.Write("Nhập tên nhân viên: ");
    string name = Console.ReadLine();

    var employee = employees.FirstOrDefault(e => e.getName().Contains(name, StringComparison.OrdinalIgnoreCase));

    if (employee != null)
    {
        Console.WriteLine($"Tìm thấy nhân viên với tên: {employee}");
        
    }
    else
    {
        Console.WriteLine($"Không tìm thấy tên {name}");
    }
}
