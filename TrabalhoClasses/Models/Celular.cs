namespace TrabalhoClasses.Models
{
    internal class Celular : Dispositivo
    {
        public Celular() { }

        public int Bateria { get; set; }

        public string SistemaOperacional { get; set; }

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
