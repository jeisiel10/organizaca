﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizacao.Sistema.Contas;

namespace Organizacao.Sistema.Testes
{
	class Teste
	{
		static void Main(string[] args)
		{
			Conta c = new Conta();
			c.Deposita(100);
			Console.WriteLine(c.Saldo);
		}
	}
}
