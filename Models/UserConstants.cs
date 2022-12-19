namespace Authentication_and_Authorization.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>(){
            new UserModel() { Username = "admin", EmailAddress = "jason.admin@email.com", Password = "Admin@123", GivenName = "Jason", Surname = "Bryant", Role = "Administrator" },
            new UserModel() { Username = "rachana", EmailAddress = "elyse.seller@email.com", Password = "Rachana@123", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },
        };
    }
}