using Microsoft.AspNetCore.Identity;

namespace WPR.Domain.Customers
{
    public sealed class Customer : IdentityUser
    {
        public Customer(string username)
            : this()
        {
            UserName = username;
        }

        private Customer()
        {
        }
    }
}
