using Domain.Models;
using Supabase;
using static Supabase.Gotrue.Constants;

namespace Server
{
    public class SupabaseQuerys
    {
        public static async Task<List<User>> GetUsers()
        {
            var response = await SupabaseSingleton.Instance.From<User>().Get();
            return response.Models;
        }

        public static async Task SignUpUser(String email, String password)
        {
            await SupabaseSingleton.Instance.Auth.SignUp(email, password);
            

        }

        public static String GetCurrentUserEmail()
        {
            return SupabaseSingleton.Instance.Auth.CurrentUser?.Email ?? "No email";
        }

        public static async Task SignInUser(String email, String password)
        {
            await SupabaseSingleton.Instance.Auth.SignIn(email, password);
        }
        public static async Task SignInWithGoogle()
        {
            await SupabaseSingleton.Instance.Auth.SignIn(Provider.Google);
        }
    }
}
