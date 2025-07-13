using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// Prototype
    /// </summary>
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract Person Clone(bool deepClone);
    }
    /// <summary>
    /// ConcretePrototype1
    /// </summary>
    public class Manager : Person
    {
        public override string Name { get; set; }
        public Manager(string name)
        {
            Name = name;
        }
        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Manager>(objectAsJson);
            }
       
                return (Person)MemberwiseClone();
            
        }
    }

    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }
        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }
        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                //var formatter = new BinaryFormatter();
                //using (var stream = new MemoryStream())
                //{
                //    formatter.Serialize(stream, this);
                //    stream.Seek(0, SeekOrigin.Begin);
                //    return (Person)formatter.Deserialize(stream);   
                //}
                var objectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Employee>(objectAsJson);
            }
            return (Person)MemberwiseClone();
        }
    }
}
