using System.ComponentModel;

namespace Common
{
    public static class Enums
    {
        public enum AdminType
        {
            AppAdmin = 0,
            ClinicAdmin = 1
        }

        public enum Gender
        {
            Male = 0,
            Female = 1,
            [Description("Rather not disclose")]
            RatherNotDisclose = 2
        }

        public enum UserType
        {
            Admin = 0,
            Doctor = 1,
            MedicalStaff = 2,
            Patient = 3
        }
    }
}
