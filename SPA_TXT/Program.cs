using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace SPA_TXT
{
    class Program
    {
        static void Main(string[] args)
        {

            var texto = EstadosBrasileiros.EstadoBrasileiroExiste("piauí");

            var teste = EstadosBrasileiros.ListarEstados();

            var result = teste.Exists(e => e.Nome.ToUpper().Equals("PIAUI"));

            var input = "M";

            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("Insira uma palavra diferente de nula ou vazia");
            var newString = input.Length > 1 ? char.ToUpper(input[0]) + input.Substring(1).ToLower() : input.ToUpper();

            newString = char.ToUpper(input[0]) + input.Substring(1).ToLower();

            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo

            string nomeArquivo = @"C:\Users\marci\Desktop\GUIAS_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            // Cria um novo arquivo e devolve um StreamWriter para ele

            StreamWriter writer = new StreamWriter(nomeArquivo);

            // Agora é só sair escrevendo

            writer.WriteLine("Aqui posso escrever o que eu quiser...");

            // Não esqueça de fechar o arquivo ao terminar

            writer.Close();

            Console.ReadKey();


            Console.WriteLine("Hello World!");

            
        }

    }
}
