namespace TsukaMotors.Models
{
    public class Veiculo
    {
        }
          //Criamos os atributos utilizando Get e Set

         public string Tipo { get; set; }

         public string Marca { get; set; }

         public string Modelo { get; set; }

         public int Ano { get; set; }

         public Veiculo(string _tipo, string _marca, string _modelo, int _ano){
            Tipo = _tipo;
            Marca = _marca;
            Modelo = _modelo;
            Ano = _ano;
        }


    }
}