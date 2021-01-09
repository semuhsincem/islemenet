using Helper.Enums;
using Microsoft.AspNetCore.Identity;

namespace MvcWebUI.IdentityCore
{
    public class AppUser :IdentityUser<int>
    {
        public string CompanyName { get; set; }
        public ERegisterRoleType RoleId { get; set; }
        public string PhoneName { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        //Section 2
        public ESex Sex { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public bool IsCheckTheContract { get; set; }
        //Section 3
        public int YearOfEstablisment { get; set; }
        public string TIN { get; set; }
        public int CompanySize { get; set; }
        public string WebSiteUrl { get; set; }
    }
}
