namespace HouseRentingSystem.Services.Agents
{
    public interface IAgentService
    {
        //bool some change UserHasRents(string userId);

        bool AgentWithPhoneNumberExists(string phoneNumber);
       
        int GetAgentId(string userId);

        bool ExistsById(string userId);

        

        void Create(string userId, string phoneNumber);
    }
}

