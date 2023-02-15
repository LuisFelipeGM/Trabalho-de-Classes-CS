using TrabalhoClasses.Interfaces;

namespace TrabalhoClasses.Models
{
    internal class Dispositivo : ITela
    {

        public float Polegadas { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int brilhoMaximo { get; set; }


        private int brilho;

        public int Brilho
        {
            get { return brilho; }
            set { brilho = value; }
        }


        public virtual void AumentarBrilho(int valor)
        {
            brilho += valor;
        }

        public virtual void DiminuirBrilho(int valor)
        {
            brilho -= valor;
        }
    }
}
