using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoNumeroSecreto
{
    public class ClasseNumeroSecreto
    {
        public enum StatusJogo { StatusParado, StatusIniciado };
        private Random rn = new Random();

        // Criar as propriedades
        // NumeroSecreto (int): Número sorteado
        // Limite (int): Limite para sorteio
        // CtdTentativas (int): contador de tentativas
        // Tentativa (int): Número fornecido pelo jogador na tentativa de acertar
        // JogoStatus (StatusJogo): Se o jogo está parado ou iniciado
        private int _numeroSecreto;

        public int NumeroSecreto
        {
            get { return _numeroSecreto; }
            set { _numeroSecreto = value; }
        }

        private int _limite;

        public int Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        private int _ctdTentativas;

        public int CtdTentativas
        {
            get { return _ctdTentativas; }
            set { _ctdTentativas = value; }
        }

        private int _tentativa;

        public int Tentativa
        {
            get { return _tentativa; }
            set { _tentativa = value; }
        }

        private StatusJogo _jogoStatus;

        public StatusJogo JogoStatus
        {
            get { return _jogoStatus; }
            set { _jogoStatus = value; }
        }

        // Declarar método que dá início ao jogo
        public void Inicia(int limite)
        {
            if (_jogoStatus == StatusJogo.StatusIniciado)
            {
                throw new Exception("Jogo já foi iniciado...");
            }
            _limite = limite;
            _numeroSecreto = rn.Next(limite);
            _ctdTentativas = 1;
            _jogoStatus = StatusJogo.StatusIniciado;
            _tentativa = -1;
        }

        // Método que avalia se a tentativa do jogador está:
        //   Abaixo do número sorteado -> Retorna 1
        //   Acima do número sorteado  -> Retorna -1
        //   Igual ao número sorteado  -> Retorna 0
        public int FazTentativa(int tentativa)
        {
            if (_jogoStatus == StatusJogo.StatusParado)
            {
                throw new Exception("Jogo não foi iniciado...");
            }
            _tentativa = tentativa;
            _ctdTentativas ++;
            if (_tentativa < _numeroSecreto) return 1;
            else if (_tentativa > _numeroSecreto) return -1;
            else
            {
                _jogoStatus = StatusJogo.StatusParado;
                return 0;
            }
        }
    }
}
