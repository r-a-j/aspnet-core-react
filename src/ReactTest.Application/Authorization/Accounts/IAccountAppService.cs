using System.Threading.Tasks;
using Abp.Application.Services;
using ReactTest.Authorization.Accounts.Dto;

namespace ReactTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
