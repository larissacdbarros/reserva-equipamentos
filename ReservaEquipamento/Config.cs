using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReservaEquipamento
{   //CRIA O DIRETÓRIO E OS ARQUIVOS TXT
    internal class Config
    {
        public string  Diretorio = @"C:\SistemaReserva";
        public string Arquivo { get; set; }

        
        public Config(string nomeArquivo)
        {
            this.Arquivo = Diretorio + nomeArquivo;
            CreateDiretorio();
            CreateArquivo(nomeArquivo);

        }

        public void CreateDiretorio()
        {
            if (!Directory.Exists(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);

            }
        }

        public void CreateArquivo(string arquivo)
        {
            this.Arquivo = arquivo;
            if (!File.Exists(Diretorio + Arquivo))
            {
                File.CreateText(Diretorio + Arquivo);
            }
        }
       
    }
}
