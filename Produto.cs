using System;
using System.Runtime.CompilerServices;

namespace ProdutoEmEstoque    //Precisa ter o mesmo nome do programa principal
{
	class Produto
	{
		//Definição das variáveis, atributos 
		public string Name;
		public double Price;
		public int Qty;

		//Método de cálculo
		public double TotalValueStock()
        {
			double initialValue = Price * Qty;
			return initialValue;
        }

		public double AddProduct()
        {
			double adding = Price*Qty;
			return adding;
        }

		public double RemovingProduct()
        {
			double removing = Price * Qty;
			return removing;
        }

	}
}


