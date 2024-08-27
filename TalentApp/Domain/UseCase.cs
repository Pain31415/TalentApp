using Domain.Models;
using Server;

namespace TalentApp.Domain
{
    public class UseCase
    {
        public static async Task<List<User>> GetUsers()
        {
            return await SupabaseQuerys.GetUsers();
        }
    }
}
