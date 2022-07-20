using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Classe.src
{

    public class Carro
    {
        public string Model { get; set; }
        public string Motor { get; set; }
        public string Brand { get; set; }
        public string Year { get; set; }

        public Carro()
        {
        }

        public Carro(string model, string motor, string year, string brand)
        {
            Model = model;
            Motor = motor;
            Brand = brand; 
            Year = year;
            
        }
        public override string ToString()
        {
            return $"Modelo: {Model};\n" +
                $"Motor: {Motor};\n" +
                $"Brand: {Brand};\n" +
                $"Ano: {Year};\n";

        }
    }

}
