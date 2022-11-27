using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareStadion : IStocareFactory
    {
        List<Stadion> GetStadioane();
        Stadion GetStadion(int id);
        bool AddStadion(Stadion m);
        bool DeleteStadion(Stadion m);
        bool UpdateStadion(Stadion m);
    }
}
