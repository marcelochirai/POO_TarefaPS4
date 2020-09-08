using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml;

namespace ProdutoEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variável
            Produto x, y, z;

            x = new Produto();
            y = new Produto();
            z = new Produto();

            Console.Write("Informe o nome do produto a ser cadastrado: ");
            x.Name = Console.ReadLine();
            Console.Write("Informe o preço do produto: ");
            x.Price = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade do produto: ");
            x.Qty = int.Parse(Console.ReadLine());

            double initialValue = x.TotalValueStock();

            Console.WriteLine("Informações sobre o produto e preço unitário: " + x.Name + "= R$ " + x.Price);
            Console.WriteLine("Total de " + x.Qty + " unidades e valor atual de R$ " + initialValue.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");

            Console.Write("Informe a quantidade a ser ADICIONADA ao estoque: ");
            y.Qty = int.Parse(Console.ReadLine());
            y.Price = x.Price;

            double adding = y.AddProduct()+initialValue;
            int sumXY = x.Qty + y.Qty;

            Console.WriteLine("Informações sobre o produto e preço unitário: " + x.Name + "= R$ " + x.Price);
            Console.WriteLine("Total atualizado de " + sumXY + " unidades e valor atual de R$ " + adding.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");

            Console.Write("Informe a quantidade a ser RETIRADA do estoque: ");
            z.Qty = int.Parse(Console.ReadLine());
            z.Price = x.Price;

            double removing = adding - z.RemovingProduct();

            Console.WriteLine("Informações sobre o produto e preço unitário: " + x.Name + "= R$ " + z.Price);
            Console.WriteLine("Total atualizado de " + (sumXY-z.Qty) + " unidades e valor atual de R$ " + removing.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");


            Console.ReadKey();

        }
    }
}
