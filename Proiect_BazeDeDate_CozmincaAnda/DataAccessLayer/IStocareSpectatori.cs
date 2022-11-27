using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareSpectatori : IStocareFactory
    {
        List<Spectator> GetSpectatori();
        Spectator GetSpectator(int id);
        bool AddSpectator(Spectator sp);
        bool DeleteSpectator(Spectator sp);
        bool UpdateSpectator(Spectator sp);
    }
}
