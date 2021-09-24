﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BancoAPI.Models
{
    public partial class Contum
    {
        public int CodConta { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public string CodigoBanco { get; set; }
        public int CodCli { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoAtual { get; set; }
        public int? CodTipoCta { get; set; }
    }
}
