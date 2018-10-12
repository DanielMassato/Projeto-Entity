using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace ArrayStruct
{
    public class Pessoas
    {
        private ArrayList lista = new ArrayList();

        private int _position;

        public int Position
        {
            get { return _position;}
            set { _position = value;}
        }

        private int _lastID;

        public int LastID
        {
            get { return _lastID; }
        }

        public int Count
        {
            get { return lista.Count;}
        }

        // 2. Propriedades com método Get
        // 3. Propriedades com método Set
        public int Codigo
        {
            get { return ((Pessoa)lista[_position]).Codigo;}            
        }

        public string Nome
        {
            get { return ((Pessoa)lista[_position]).Nome; }
            set
            { 
                Pessoa p = new Pessoa(this.Codigo, value, this.EMail, this.Fone, this.DataNasc);
                lista[_position] = p;
            }
        }

        public string EMail
        {
            get { return ((Pessoa)lista[_position]).EMail; }
            set
            {
                Pessoa p = new Pessoa(this.Codigo, this.Nome, value, this.Fone, this.DataNasc);
                lista[_position] = p;
            }
        }

        public string Fone
        {
            get { return ((Pessoa)lista[_position]).Fone; }
            set
            {
                Pessoa p = new Pessoa(this.Codigo, this.Nome, this.EMail, value, this.DataNasc);
                lista[_position] = p;
            }

        }

        public DateTime DataNasc
        {
            get { return ((Pessoa)lista[_position]).DataNasc; }
            set
            {
                Pessoa p = new Pessoa(this.Codigo, this.Nome, this.EMail, this.Fone, value);
                lista[_position] = p;
            }
        }

        public void Add(string nome, string email, string fone, DateTime dataNasc)
        {
            lista.Add( new Pessoa( ++_lastID, nome, email, fone, dataNasc ) );
            _position = lista.Count - 1;
        }

        public void MoveFirt()
        {
            _position = 0;
        }

        public void MoveLast()
        {
            _position = lista.Count - 1;
        }

        public bool MoveNext()
        {
            if (_position >= lista.Count - 1) return false;
            _position++;
            return true;
        }

        public bool MovePrevious()
        {
            if (_position <= 0) return false;
            _position--;
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index > lista.Count - 1) return false;
            int newPointer;
            if (index == lista.Count - 1) newPointer = index - 1;
            else newPointer = index - 1;
            // apaga o elemento atual
            lista.RemoveAt(index);
            _position = lista.Count > 0 ? newPointer : -1;
            return true;
        }

        public Pessoas()
        {
            _lastID = 0;
        }

        public Pessoa this[int index]
        {
            get 
            {
                if (index < 0 || index > lista.Count - 1)
                    throw new Exception("Índice fora dos limites da lista...");
                return (Pessoa)lista[index]; 
            }
            set 
            {
                if (index < 0 || index > lista.Count - 1)
                    throw new Exception("Índice fora dos limites da lista...");
                lista[index] = value; 
            }
        }

        public void SaveToFile(string fileName)
        {
            StreamWriter sw = new StreamWriter( fileName );
            for (int i = 0; i < lista.Count; i++)
            {
                _position = i;
                sw.WriteLine(Codigo.ToString() + "|" + Nome + "|" + EMail + "|" + Fone + "|" + DataNasc.ToString("dd/MM/yyyy"));

            }
            sw.Close();
        }

        public void LoadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            try
            {
                _lastID = 0;
                // enquanto não for final do arqivo
                while (!sr.EndOfStream)
                {
                    // lê a linha atual do arquivo texto
                    string linha = sr.ReadLine();
                    // separa os campos da linha pelo caractere "pipe" 
                    string[] dados = linha.Split('|');
                    // insere os dados na lista na memória
                    lista.Add(new Pessoa(int.Parse(dados[0]),
                                            dados[1], dados[2], dados[3],
                                            Convert.ToDateTime(dados[4])));
                    if (int.Parse(dados[0]) > _lastID) _lastID = int.Parse(dados[0]);
                }
                _position = 0;
            }
            catch
            {
                throw new Exception("Arquivo inválido...");
            }
            finally
            {
                sr.Close();
                sr.Dispose();
            }
        }

        public int IndexOfCodigo(int cod)
        {
            int pos = -1;
            for (int i = 0; i <= lista.Count-1; i++)
                if (this[i].Codigo == cod)
                {
                    pos = i;
                    break;
                }
            return pos;
        }

        public int IndexOfNome(string nome)
        {
            int pos = -1;
            for (int i = 0; i <= lista.Count - 1; i++)
                if (this[i].Nome == nome)
                {
                    pos = i;
                    break;
                }
            return pos;
        }

        // 1.
        public struct Pessoa
        {
            public int Codigo;
            public string Nome;
            public string EMail;
            public string Fone;
            public DateTime DataNasc;

            public Pessoa(int codigo, string nome,
                           string email, string fone,
                           DateTime dataNasc)
            {
                Codigo = codigo;
                Nome = nome;
                EMail = email;
                Fone = fone;
                DataNasc = dataNasc;
            }
        }

    }
}
