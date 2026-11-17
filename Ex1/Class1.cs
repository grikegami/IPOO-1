using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Carro
    {
       
        public string Fabricante;
        public string Modelo;
        public int AnoFabricacao;
        public int AnoModelo;
        public double ValorVenda;

        public void setFabricante(string fabricante)
        {
            Fabricante = fabricante;
        }

        public void setModelo(string modelo)
        {
            Modelo = modelo;
        }

        public void setAnoFabricacao(int anoFabricacao)
        {
            AnoFabricacao = anoFabricacao;
        }

        public void setAnoModelo(int anoModelo)
        {
            AnoModelo = anoModelo;
        }
        public void setValorVenda(double valorVenda)
        {
            ValorVenda = valorVenda;
        }

        public string getFabricante()
        {
            return Fabricante;
        }

        public string getModelo()
        {
            return Modelo;
        }

        public int getAnoFabricacao()
        {
            return AnoFabricacao;
        }

        public int getAnoModelo()
        {
            return AnoModelo;
        }
        public double getVarlorVenda()
        {
            return ValorVenda;
        }

        public override string ToString()
        {
            return $"Fabricante: {this.Fabricante}\nModelo: {this.Modelo}\nAno de fabricação: {this.AnoFabricacao}\nAno do Modelo: {this.AnoModelo}\nValor de Venda: {this.ValorVenda}";
        }
    }

}
