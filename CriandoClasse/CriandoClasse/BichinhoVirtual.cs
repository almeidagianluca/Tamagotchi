using System;
using System.Collections.Generic;
using System.Text;

namespace CriandoClasse
{
    class BichinhoVirtual
    {
        // Atributos
        public String Nome;
        public int Idade;
        private int _energia;
        private int _fome;
        private int _sede;
        private Boolean _estaDoente;

        // Métodos
        public BichinhoVirtual() { 
            Nome = "Tamagotchi";
            Idade = 0;
            _energia = 100;
            _fome = 10;
            _sede = 10;
        }
        public void comer() {
            int desconto = (_fome * 30) / 100;
            _fome = _fome - desconto;
        }
        public void beberAgua() {
            int desconto = (_sede * 20) / 100;
            _sede = _sede - desconto;
        }
        public void dormir() {
            _energia = 100;
        }
        public void brincar() {
            _fome = _fome + ((_fome * 40) / 100);
            if (_fome > 50) {
                _energia = _energia - ((_energia * 10)/100);
            }

            _sede = _sede + ((_sede * 10) / 100);
            if (_sede > 80) {
                _estaDoente = true;
            }

            _energia = _energia - ((_energia * 25) / 100);
        }
        public void seCurar() {
            _estaDoente = false;
        }
        override
        public String ToString() {
            String retorno =
                Nome + ", " + Idade + " anos" +
                "\nFome: " + _fome +
                "\nSede: " + _sede +
                "\nEnergia: " + _energia;
            if (_estaDoente)
                retorno = retorno + "\nEstá doente!";
            else
                retorno = retorno + "\nNão está doente.";

            return retorno;
        }

    }
}
