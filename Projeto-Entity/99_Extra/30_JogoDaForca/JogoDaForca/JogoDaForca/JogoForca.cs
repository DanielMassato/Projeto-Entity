using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace JogoDaForca
{
    /// <summary>
    /// Jogo da Forca. 
    /// </summary>
    public class JogoForca
    {
        //--------------------------------------------------------------------------VARIÁVEIS AUXILIARES
        // Armazena a palavra que foi sorteada
        private string palavraSorteada;
        // Armazena as dicas da palavra que foi sorteada
        private List<string> dicasDaPalavra = new List<string>();
        // lista com quantidade de elementos igual a quantidade de letras ta palavra
        // letras já acertadas serão preenchidas com 1 as outras com zero
        private List<byte> posicoesCertas = new List<byte>();
        // gerador de números aleatórios
        private Random rn = new Random();
        // lista de letras já acertadas
        private List<char> letrasCertas = new List<char>();

        /// <summary>
        /// Classe que formará cada elemento da lista de palavras e da lista de dicas
        /// </summary>
        public class Tabela
        {
            public int Codigo;
            public string Descricao;

            public Tabela(int cod, string desc)
            {
                Codigo = cod;
                Descricao = desc;
            }
        }
        //--------------------------------------------------------------------------PROPRIEDADES
        /// <summary>
        /// Lista de palavras 
        /// </summary>
        public List<Tabela> palavras = new List<Tabela>();
        /// <summary>
        /// Lista de dicas para cada palavra
        /// </summary>
        public List<Tabela> dicas = new List<Tabela>();

        /// <summary>
        /// Define as opções para o status do jogo
        /// </summary>
        public enum JogoForcaStatusJogo { StatusNaoIniciado, StatusIniciado, StatusGanhou, StatusPerdeu };        
        /// <summary>
        /// sinaliza o status do jogo
        /// </summary>
        public JogoForcaStatusJogo StatusJogo;
        /// <summary>
        /// Contado de dicas que o jogador já pediu
        /// </summary>
        public byte CtdDicas;
        /// <summary>
        /// Define o limite de dicas possíveis
        /// </summary>
        public byte LimiteDeDicas;
        /// <summary>
        /// Contador de acertos
        /// </summary>
        public int CtdAcertos;
        /// <summary>
        /// Contador de erros
        /// </summary>
        public int CtdErros;
        /// <summary>
        /// Limite de erros permitido
        /// </summary>
        public int LimiteDeErros;

        
        private List<byte> _posicoesDaLetra;
        /// <summary>
        /// Posicos na palavra onde aparece a letra que o jogador acaba de acertar
        /// </summary>
        public List<byte> PosicoesDaLetra
        {
            get { return _posicoesDaLetra; }        
        }

        //--------------------------------------------------------------------------MÉTODOS DO JOGO
        /// <summary>
        /// Lê o arquivo XML contendo as palavras e as dicas e transfere tudo para as listas
        /// </summary>
        public void LoadXML()
        {
            XmlTextReader textReader = new XmlTextReader("palavras.xml");
            int cod = 0;
            
            while (textReader.Read())
            {
                XmlNodeType nType = textReader.NodeType;
                
                if (nType == XmlNodeType.Element && textReader.Name.ToString() == "nome")
                {
                    textReader.Read();
                    cod++;
                    palavras.Add( new Tabela(cod, textReader.Value) );
                }
                if (nType == XmlNodeType.Element && textReader.Name.ToString() == "dica")
                {
                    textReader.Read();
                    dicas.Add(new Tabela(cod, textReader.Value));
                }
            }
            textReader.Close();
        }

        /// <summary>
        /// Inicia o jogo e inicializa as propriedades
        /// </summary>
        /// <returns>Retorna com a palavra sorteada</returns>
        public string Inicia()
        {
            LoadXML();
            int ns = rn.Next(palavras.Count);
            int cod = palavras[ns].Codigo;
            var dicasSelecionadas = from d in dicas
                                    where (d.Codigo == cod)
                                    select new { d.Descricao };
            palavraSorteada = palavras[ns].Descricao;
            dicasDaPalavra.Clear();
            for (int i = 0; i < dicasSelecionadas.ToList().Count;i++ )
            {
                this.dicasDaPalavra.Add( dicasSelecionadas.ToList()[i].Descricao );
            }

            StatusJogo = JogoForcaStatusJogo.StatusIniciado;
            if (posicoesCertas != null) posicoesCertas.Clear();

            for (int i = 0; i < palavraSorteada.Length; i++) posicoesCertas.Add(0);
            
            if (_posicoesDaLetra != null) _posicoesDaLetra.Clear();

            _posicoesDaLetra = new List<byte>();

            CtdDicas = 0;
            LimiteDeDicas = 3;
            CtdAcertos = 0;
            CtdErros = 0;
            LimiteDeErros = 6;
            letrasCertas.Clear();

            return palavraSorteada;
        }

        /// <summary>
        /// Devolve uma dica sobre a palavra sorteada
        /// </summary>
        /// <returns>Dica selecionada</returns>
        public string PedeDica()
        {
            if (CtdDicas > LimiteDeDicas || CtdDicas >= dicasDaPalavra.Count)
                return "";
            else
            {
                CtdErros+=2;
                return dicasDaPalavra[CtdDicas++];
            }
        }

        /// <summary>
        /// Analiza a tentativa do jogador
        /// </summary>
        /// <param name="letra">Letra que o jogador submete ao teste</param>
        /// <returns>true se a letra existe na palavra, caso contrário false</returns>
        public bool FazTentativa(char letra)
        {
            // verifica a primeira posição  onde a letra aparece na palavra
            int pos = palavraSorteada.IndexOf(letra);
            // define retorno false inicialmente
            bool result = false;
            // se o jogo não foi iniciado gera um erro
            if (StatusJogo != JogoForcaStatusJogo.StatusIniciado)
                throw new Exception("Jogo não foi iniciado...");
            else
            {                
                // se a letra não existe na palavra ou a letra já foi acertada
                if (pos < 0 || letrasCertas.IndexOf(letra) >= 0)
                {
                    CtdErros++;
                    if (CtdErros >= LimiteDeErros)
                    {
                        StatusJogo = JogoForcaStatusJogo.StatusPerdeu;
                    }
                }
                else
                {
                    CtdAcertos++;
                    // limpa a lista contendo as posições onde a letra aparece na palavra
                    _posicoesDaLetra.Clear();
                    // adiciona a letra na lista de letras acertadas
                    letrasCertas.Add(letra);
                    // redefine a lista de posições da palavra onde a letra aparece e
                    // a lista de posições já acertadas
                    for (int i = 0; i < palavraSorteada.Length; i++)
                        if (palavraSorteada[i] == letra)
                        {
                            _posicoesDaLetra.Add((byte)i);
                            posicoesCertas[i] = 1;
                        }
                    // se não existirem zeros na lista de posições acertadas, indica que o jogador venceu
                    if (posicoesCertas.IndexOf(0) < 0)
                        StatusJogo = JogoForcaStatusJogo.StatusGanhou;
                    result = true;
                }
            }
            return result;
        }

        //--------------------------------------------------------------------------MÉTODOS DE GERENCIAMENTO DA LISTA DE PALAVRAS
        /// <summary>
        /// Adiciona palavra na lista
        /// </summary>
        /// <param name="palavra">Palavra que será adicionada</param>
        /// <returns>true se palavra foi adicionada, false se palavra já estava na lista</returns>
        public bool AdicionaPalavra(string palavra)
        {
            var conta = from c in palavras
                        where (c.Descricao == palavra)
                        select new
                        {
                            c.Codigo
                        };
            if (conta.ToList().Count == 0)
            {
                palavras.Add(new JogoForca.Tabela(palavras.Count + 1, palavra));
                return true;
            }
            else
                return false; ;
        }
        /// <summary>
        /// Adiciona uma dica para uma palavra
        /// </summary>
        /// <param name="cod">Código da palabra dentro da lista de palavras</param>
        /// <param name="dica">Dica que será inserida</param>
        /// <returns>true se a dica foi inserida ou false se a dica já existir para a palavra</returns>
        public bool AdicionaDica(int cod, string dica)
        {
            var conta = from d in dicas
                        where (d.Codigo == cod && d.Descricao == dica)
                        select new { d.Codigo };
            bool result = true;
            if (conta.ToList().Count == 0)
                dicas.Add(new Tabela(cod, dica));
            else result = false;

            return result;
        }

        /// <summary>
        /// Salva as listas de palavras e dicas no arquivo XML
        /// </summary>
        public bool SaveXML()
        {
            XmlTextWriter writer = new XmlTextWriter("palavras.xml", null);
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("palavras", "");
                for (int i = 0; i < palavras.Count; i++)
                {
                    int cod = palavras[i].Codigo;
                    var dicasSelecionadas = from d in dicas
                                            where (d.Codigo == cod)
                                            select new { d.Descricao };
                    writer.WriteStartElement("palavra", "");
                    writer.WriteStartElement("nome", "");
                    writer.WriteString(palavras[i].Descricao);
                    writer.WriteEndElement();
                    for (int j = 0; j < dicasSelecionadas.ToList().Count; j++)
                    {
                        writer.WriteStartElement("dica", "");
                        writer.WriteString(dicasSelecionadas.ToList()[j].Descricao);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
