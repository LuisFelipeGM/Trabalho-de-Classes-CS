using System.ComponentModel.DataAnnotations;
using TrabalhoClasses.Interfaces;

namespace TrabalhoClasses.Models
{
    internal class Dispositivo : ITela
    {
        [Required(ErrorMessage = "As Polegadas são obrigátorias!", AllowEmptyStrings = false)]
        public float Polegadas { get; set; }

        [Required(ErrorMessage = "A Marca é obrigatório", AllowEmptyStrings = false)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Modelo é obrigatório", AllowEmptyStrings = false)]
        public string Modelo { get; set; }

        [Display(Name = "Brilho Máximo")]
        public int brilhoMaximo { get; set; }

        [Display(Name = "Brilho Atual")]
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
