using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_Hotel.Model
{

    public class Hospedagem : ContentPage
    {
        Suite quarto;
        int qnt_adultos;

        public int QntAdultos
        {
            get => qnt_adultos;
            
            set
            {
                if (value == 0)
                    throw new Exception("Por favor, informe a quantidade de adultos");

                qnt_adultos = value;
            }

        }
        public int QntCriancas { get; set; }
        
        public Suite Quarto
        {
            get => quarto;

            set
            {
                if (value == null)
                    throw new Exception("Por favor selecione uma Suite. ");

                  quarto = value;

            }
        }
        
        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckOut).Days;
            }
        }
    }
}