﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Business
{
    public class Periodo
    {
        DateTime dataInicial;
        DateTime dataFinal;

        Periodo (DateTime dInicial, DateTime dFinal)
        {
            if (dInicial > dFinal)
                throw new Exception("Periodo invalido");
            this.dataInicial = dInicial;
            this.dataFinal = dFinal;
        }

    }
}
