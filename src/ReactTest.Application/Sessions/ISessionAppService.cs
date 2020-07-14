using System.Threading.Tasks;
using Abp.Application.Services;
using ReactTest.Sessions.Dto;

namespace ReactTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
