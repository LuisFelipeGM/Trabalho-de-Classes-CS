using System.ComponentModel.DataAnnotations;

namespace TrabalhoClasses.Models
{
    internal class Televisao : Dispositivo
    {
        public Televisao() { }

        [Required]
        [Display(Name = "Modo de Exibição")]
        private string modo;

        public string Modo
        {
            get { return modo; }
        }

        public override void AumentarBrilho(int valor)
        {
            try
            {
                if ((valor + Brilho) <= brilhoMaximo)
                {
                    base.AumentarBrilho(valor);
                }
                else
                {
                    throw new Exception("\nO Brilho passou do máximo permitido! Tente novamente");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public override void DiminuirBrilho(int valor)
        {
            try
            {

                if ((Brilho - valor) >= 0)
                {
                    base.DiminuirBrilho(valor);
                }
                else
                {
                    base.DiminuirBrilho(Brilho);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        public void AlterarModo(int num)
        {
            modo = num switch
            {
                0 => "Padrão",
                1 => "Futebol",
                2 => "Cinema",
                3 => "Jogo",
                _ => "Padrão",
            };
        }

    }
}
