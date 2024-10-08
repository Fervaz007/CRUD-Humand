using Microsoft.AspNetCore.Identity;

namespace CRUD_Humand.Models
{
    public class User
    {
        public string password { get; set; }

        public List<Relationship> relationships { get; set; }

        public string empployeeInternalId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; } 
    }
}
