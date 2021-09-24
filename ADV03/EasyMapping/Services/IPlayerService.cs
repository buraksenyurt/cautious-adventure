using EasyMapping.Models;
using System.Collections.Generic;

namespace EasyMapping.Services
{
    public interface IPlayerService
    {
        List<PlayerModel> GetPlayers();
    }
}
