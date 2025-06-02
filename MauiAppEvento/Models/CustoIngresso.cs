using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEvento.Models
{
    public class CustoIngresso
    {
        public IngressoTipo LocalSelecionado { get; set; }
        public int QntParticipantes { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        public int Participacao 
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public double ValorTotal 
        {
            get 
            {
                double valor_ingresso = QntParticipantes * LocalSelecionado.ValorIngresso;
                
                double total = valor_ingresso * Participacao;

                return total;
            }
        
        }
    }
}
