using System;

namespace Employee.Entity
{
    public class EmployeeDatabase
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Designation { get; set; }

        public EmployeeDatabase(string name, string id, string designation)
        {
            this.Name =name;
            this.Id = id;
            this.Designation = designation;
        }
    }
}
