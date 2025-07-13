using Prototype;

Console.Title = "Prototype";
var manager = new Manager("Gyanendra Chaudhary");
var managerClone = (Manager)manager.Clone();

Console.WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("Gyanendra.C", managerClone);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee was cloned: {employeeClone.Name}," + $" with manager {employeeClone.Manager.Name}");

managerClone.Name = "Chaudhary";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}," + $" with manager {employeeClone.Manager.Name}");