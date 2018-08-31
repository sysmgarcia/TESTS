using SPA_TXT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SPA_TXT
{
    public class EstadosBrasileiros
    {

        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public static List<EstadosBrasileiros> ListarEstados()
        {
            var ListaEstadosBrasileiros = new List<EstadosBrasileiros>();

            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 1, Sigla = "AC", Nome = "ACRE" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 2, Sigla = "AL", Nome = "ALAGOAS" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 3, Sigla = "AP", Nome = "AMAPÁ" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 4, Sigla = "AM", Nome = "AMAZONAS" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 5, Sigla = "BA", Nome = "BAHIA" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 6, Sigla = "CE", Nome = "CEARÁ" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 7, Sigla = "DF", Nome = "DISTRITO FEDERAL" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 8, Sigla = "ES", Nome = "ESPÍRITO SANTO" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 9, Sigla = "RR", Nome = "RORAIMA" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 10, Sigla = "GO", Nome = "GOIÁS" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 11, Sigla = "MA", Nome = "MARANHÃO" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 12, Sigla = "MT", Nome = "MATO GROSSO" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 13, Sigla = "MS", Nome = "MATO GROSSO DO SUL" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 14, Sigla = "MG", Nome = "MINAS GERAIS" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 15, Sigla = "PA", Nome = "PARÁ" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 16, Sigla = "PB", Nome = "PARAÍBA" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 17, Sigla = "PR", Nome = "PARANÁ" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 18, Sigla = "PE", Nome = "PERNAMBUCO" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 19, Sigla = "PI", Nome = "PIAUÍ" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 20, Sigla = "RJ", Nome = "RIO DE JANEIRO" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 21, Sigla = "RN", Nome = "RIO GRANDE DO NORTE" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 22, Sigla = "RS", Nome = "RIO GRANDE DO SUL" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 23, Sigla = "RO", Nome = "RONDÔNIA" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 24, Sigla = "TO", Nome = "TOCANTINS" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 25, Sigla = "SC", Nome = "SANTA CATARINA" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 26, Sigla = "SP", Nome = "SÃO PAULO" });
            ListaEstadosBrasileiros.Add(new EstadosBrasileiros { Id = 27, Sigla = "SE", Nome = "SERGIPE" });

            return ListaEstadosBrasileiros;
        }

        public static bool EstadoBrasileiroExiste(string nome)
        {
            return ListarEstados().Exists(e => Helpers.RemoveAccents(e.Nome.ToUpper()).Equals(Helpers.RemoveAccents(nome.ToUpper())));
        }

    }
}
