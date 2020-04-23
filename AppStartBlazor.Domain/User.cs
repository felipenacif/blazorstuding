using System.ComponentModel.DataAnnotations;

namespace AppStartBlazor.Domain
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(100), EmailAddress]
        public string Login { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public bool Active { get; set; }
    }
}