using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Pessoas : List<Pessoa>
    {
        // já herda os métodos Add, Insert, RemoveAt etc...
        // aí iria criar uma propriedade para armazenar os veículos da pessoa,
        

        public Pessoas()
        {
            
        }

    }

    public class Veiculos : List<Veiculo>
    {
        // já herda os métodos Add, Insert, RemoveAt etc...
    }

    class Veiculo
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private string _modelo;

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        private string _placas;

        public string Placas
        {
            get { return _placas; }
            set { _placas = value; }
        }

        private int ano;

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public Veiculo(int id, string marca, string modelo, string placas, int ano)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Placas = placas;
            Ano = ano;
        }
    }
    
    class Pessoa
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
            _veiculosPessoa = new Veiculos();
        }

       
        private Veiculos _veiculosPessoa;

        public Veiculos VeiculosPessoa
        {
            get { return _veiculosPessoa; }
            set { _veiculosPessoa = value; }
        }
    }
}
