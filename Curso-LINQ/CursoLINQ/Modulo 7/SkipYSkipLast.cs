﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7
{
    public class SkipYSkipLast
    {
        public void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 100);

            var primeros10Numeros = numeros.Take(10).ToList();
            var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

            var ultimos10Numeros = numeros.TakeLast(10).ToList();
            var penultimoLote = numeros.SkipLast(10).TakeLast(10).ToList();
        }
    }
}
