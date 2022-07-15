namespace MVCDemo.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime CreatedDate { get; set; }
        public int YearsOfExperience { get; set; }

        public bool IsPermanentEmployee
        {
            get
            {
                return YearsOfExperience >= 5;
            }
        }

        public string RowCssColor
        {
            get
            {
                return IsPermanentEmployee ? "blue" : "yellow";
            }
        }
    }
}