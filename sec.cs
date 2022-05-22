
// Создать list сотрудников.
var list = new List<Person>();


// Добавить сотрудников в list.
list.Add(new Person(1, 1, "Иванов", 1000, new DateTime(2000, 1, 1), 0.1, 0.1, 30, 365, 0, 0));

// Функция поиска Person в List по запрошенному полю и значению
Person FindPerson(List<Person> list, string field, string value)
{
    Person person = new Person();
    switch (field)
    {
        case "TabNumber":
            person = list.Find(x => x.TabNumber == Convert.ToInt32(value));
            break;
        case "DepartmentNumber":
            person = list.Find(x => x.DepartmentNumber == Convert.ToInt32(value));
            break;
        case "Surname":
            person = list.Find(x => x.Surname == value);
            break;
        case "DateOfEmployment":
            person = list.Find(x => x.DateOfEmployment == Convert.ToDateTime(value));
            break;
    }
    return person;
}



// Вывод того что нашлось по запросу фамилии Иванов в консоль
Console.WriteLine(FindPerson(list, "Surname", "Иванов"));
// Сотрудник представлен структурой Person с полями: табельный номер, номер отдела, фамилия, оклад, дата поступления на работу, процент надбавки, процент налоговых сборов, количество отработанных дней в месяце, количество рабочих дней в месяце, начислено, удержано. Поиск и сортировка — по номеру отдела, дате поступления на работу, фамилии.
struct Person
{
    public int TabNumber
    {
        get; set;
    }
    public int DepartmentNumber
    {
        get; set;
    }
    public string Surname
    {
        get; set;
    }
    public double Salary
    {
        get; set;
    }
    public DateTime DateOfEmployment
    {
        get; set;
    }
    public double PercentOfSalary
    {
        get; set;
    }
    public double PercentOfTaxes
    {
        get; set;
    }
    public int WorkingDaysInMonth
    {
        get; set;
    }
    public int WorkingDaysInYear
    {
        get; set;
    }
    public double Nach
    {
        get; set;
    }
    public double Ud
    {
        get; set;
    }

    public Person(int tabNumber, int departmentNumber, string surname, double salary, DateTime dateOfEmployment, double percentOfSalary, double percentOfTaxes, int workingDaysInMonth, int workingDaysInYear, double nach, double ud)
    {
        TabNumber = tabNumber;
        DepartmentNumber = departmentNumber;
        Surname = surname;
        Salary = salary;
        DateOfEmployment = dateOfEmployment;
        PercentOfSalary = percentOfSalary;
        PercentOfTaxes = percentOfTaxes;
        WorkingDaysInMonth = workingDaysInMonth;
        WorkingDaysInYear = workingDaysInYear;
        Nach = nach;
        Ud = ud;
    }
}
