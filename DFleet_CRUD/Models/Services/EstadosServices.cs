using DFleet_CRUD.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFleet_CRUD.Models.Services
{
    public class EstadosServices
    {
        public static List<Abastecimento> Abastecimentos()
        {
            var listaAbastecimento = new List<Abastecimento>()
            {
                new Abastecimento(){CombustivelUtilizado = "ARLA 32" },
                new Abastecimento(){CombustivelUtilizado = "DIESEL" },
                new Abastecimento(){CombustivelUtilizado = "DIESEL S-10" },
                new Abastecimento(){CombustivelUtilizado = "DIESEL S-50" },
                new Abastecimento(){CombustivelUtilizado="DIESEL S-500"},
                new Abastecimento(){CombustivelUtilizado="ETANOL"},
                new Abastecimento(){CombustivelUtilizado="ETANOL ADITIVADO"},
                new Abastecimento(){CombustivelUtilizado="GASOLINA ADITIVADA"},
                new Abastecimento(){CombustivelUtilizado="GASOLINA COMUM"},
                new Abastecimento(){CombustivelUtilizado="GASOLINA PREMIUM"},
                new Abastecimento(){CombustivelUtilizado="GNV"}

            };

            return listaAbastecimento;
        }

        public static List<Abastecimento> ListaAbastecimentos()
        {
            var abastecimentoLista = new List<Abastecimento>()
            {
                new Abastecimento(){CombustivelUtilizado = "ABASTECIMENTO INTERNO" },
                new Abastecimento(){CombustivelUtilizado = "ARLA 32" },
                new Abastecimento(){CombustivelUtilizado = "COMBOIO" },
                new Abastecimento(){CombustivelUtilizado = "NORMAL" },
                new Abastecimento(){CombustivelUtilizado = "PARTIDA A FRIO"},
            };

            return abastecimentoLista;
        }
    }
}
