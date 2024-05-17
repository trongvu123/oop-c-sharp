using DemoOOP2;

List<Employee> employees = new List<Employee>();
List<Customer> customers = new List<Customer>();

// Add some sample employees and customers for testing
employees.Add(new Employee("Nguyen Van A", "adress1", 5000));
employees.Add(new Employee("Nguyen Van B", "adress2", 6000));
customers.Add(new Customer("Nguyen Van C", "adress3", 2000));
customers.Add(new Customer("Nguyen Van D", "adress4", 1500));

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Thêm nhân viên");
    Console.WriteLine("2. Thêm khách hàng");
    Console.WriteLine("3. Tìm nhân viên có lương cao nhất");
    Console.WriteLine("4. Tìm khách hàng có số dư nhỏ nhất");
    Console.WriteLine("5. Tìm nhân viên theo tên");
    Console.WriteLine("6. Thoát");
    Console.Write("Chọn một lựa chọn: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddEmployee(employees);
            break;
        case 2:
            AddCustomer(customers);
            break;
        case 3:
            FindHighestSalaryEmployee(employees);
            break;
        case 4:
            FindLowestBalanceCustomer(customers);
            break;
        case 5:
            FindEmployeeByName(employees);
            break;
        case 6:
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
            break;
    }
}


   static void AddEmployee(List<Employee> employees)
{
    try
    {
        Console.Write("Nhập tên nhân viên: ");
        string name = Console.ReadLine();

        Console.Write("Nhập địa chỉ nhân viên: ");
        string address = Console.ReadLine();

        Console.Write("Nhập lương của nhân viên: ");
        int salary = int.Parse(Console.ReadLine());

        employees.Add(new Employee(name, address, salary));
    }
    catch (Exception e)
    {
        Console.WriteLine("Dữ liệu nhập không hợp lệ: " + e.Message);
    }
}
 static void AddCustomer(List<Customer> customers)
{
    try
    {
        Console.Write("Nhập tên khách hàng: ");
        string name = Console.ReadLine();

        Console.Write("Nhập địa chỉ khách hàng: ");
        string address = Console.ReadLine();

        Console.Write("Nhập số dư của khách hàng: ");
        int balance = int.Parse(Console.ReadLine());

        customers.Add(new Customer(name, address, balance));
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

    var highestSalaryEmployee = employees.OrderByDescending(e => e.salary).FirstOrDefault();

    if (highestSalaryEmployee != null)
    {
        Console.WriteLine("Nhân viên có lương cao nhất: ");
        highestSalaryEmployee.Display();
    }
    else
    {
        Console.WriteLine("Không tìm thấy nhân viên.");
    }
}

static void FindLowestBalanceCustomer(List<Customer> customers)
{
    if (customers.Count == 0)
    {
        Console.WriteLine("Không có khách hàng nào trong danh sách.");
        return;
    }

    var lowestBalanceCustomer = customers.OrderBy(c => c.balance).FirstOrDefault();

    if (lowestBalanceCustomer != null)
    {
        Console.WriteLine("Khách hàng có số dư nhỏ nhất: ");
        lowestBalanceCustomer.Display();
    }
    else
    {
        Console.WriteLine("Không tìm thấy khách hàng.");
    }
}

static void FindEmployeeByName(List<Employee> employees)
{
    Console.Write("Nhập tên nhân viên: ");
    string name = Console.ReadLine();

    var employee = employees.FirstOrDefault(e => e.getName().Contains(name, StringComparison.OrdinalIgnoreCase));

    if (employee != null)
    {
        Console.WriteLine("Tìm thấy nhân viên với tên: ");
        employee.Display();
    }
    else
    {
        Console.WriteLine($"Không tìm thấy tên {name}");
    }
}