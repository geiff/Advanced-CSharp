namespace HomeFunctionalProgramming
{
    class StudentSpecialty
    {
        private string specialtyName;
        private string facultyNumber;

        public StudentSpecialty(string specialtyName, string facultyNumber)
        {
            this.FacultyNumber = facultyNumber;
            this.SpecialtyName = specialtyName;
        }

        public string SpecialtyName { get; set; }
        public string FacultyNumber { get; set; }
    }
}
