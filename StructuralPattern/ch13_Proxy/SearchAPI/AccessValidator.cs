namespace ch13_Proxy.SearchAPI
{
    public class AccessValidator
    {
        public bool Validate(string userId){
            System.Console.WriteLine("Check user '{0}' if is valid?", userId);
            if (userId.Equals("Hulk"))
            {
                System.Console.WriteLine("User '{0}' login successfully!", userId);
                return true;
            }else{
                System.Console.WriteLine("User '{0}' login failed!", userId);
                return false;
            }
        }
    }
}