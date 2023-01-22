using System;
using System.IO;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||     //Código utilizado para substituir o ~ pela pasta home do usuário no sistema
                Environment.OSVersion.Platform == PlatformID.MacOSX)                //PlatformID.Unix = Linux
                ? Environment.GetEnvironmentVariable("HOME")                        //PlatformId.MacOSX = MacOs
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");  //Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") = Windows
            return path.Replace("~", home);
        }
    }

    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            //O @ é importante ao utilizar path's para que o sistema não interprete o \ como alguma instrução específica
            //como, por exemplo o \n que acrescenta uma quebra de linha.
            var path = @"~/primeiro_arquivo.txt".ParseHome(); // o ~ é utilizado para referenciar a pasta Home do usuário do sistema.

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
