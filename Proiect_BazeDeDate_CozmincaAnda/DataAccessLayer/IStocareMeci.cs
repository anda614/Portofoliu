using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareMeci : IStocareFactory
    {
        List<Meci> GetMeciuri();
        Meci GetMeci(int id);
        bool AddMeci(Meci m);
        bool DeleteMeci(Meci m);
        bool UpdateMeci(Meci m);
    }
}
