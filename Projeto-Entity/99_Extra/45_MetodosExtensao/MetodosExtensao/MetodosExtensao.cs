using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetodosExtensao
{
    public static class MetodosExtensao
    {
        public static bool EhDecimal(this string valor)
        {
            try
            {
                Convert.ToDecimal(valor);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static decimal ToDecimal(this string valor)
        {
            try
            {
                return Convert.ToDecimal(valor); ;
            }
            catch (Exception)
            {
                throw new Exception("Dado não é numérico");                
            }
        }

        public static int ToInt32(this string valor)
        {
            try
            {
                return Convert.ToInt32(valor); ;
            }
            catch (Exception)
            {

                throw new Exception("Dado não é numérico inteiro");                
            }
        }

        public static int ContaPalavras(this string texto)
        {
            string[] palavras = texto.Split(new char[] { ' ', ',', '.', '?', '!', ';' });
            return palavras.Length;
        }

        public static string PegaPalavra(this string texto, uint pos)
        {
            string[] palavras = texto.Split(new char[] { ' ', ',', '.', '?', '!', ';' });
            if (pos < palavras.Length)
                return palavras[pos];
            else
                return "";
        }

        public static string NomeProprio(this string texto)
        {
            string nome = "";
            int qtdPalavras = texto.ContaPalavras();
            for (int i = 0; i < qtdPalavras; i++)
            {
                string p = texto.PegaPalavra((uint)i);
                if ("DE,DO,DAS,DOS".Contains(p.ToUpper()))
                    p = p.ToLower();
                else
                    p = p.Substring(0, 1).ToUpper() + p.Substring(1).ToLower();
                nome += p + " ";
            }
            return nome.Trim();
        }

        public static ulong Fatorial(this byte valor)
        {
            if (valor <= 1)
                return 1;
            else
                return valor * Fatorial((byte)(valor - 1));
        }
    }
}
