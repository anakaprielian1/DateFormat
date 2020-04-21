using System;

namespace Library
{
    public class OtroFormato
    {
        public object Valor { get; set; }

        public void ConvertirSeparadores(string fecha)
        {
            // Primera prueba
            // this.Valor = "01-01-2020";

            // Implementacion
            this.Valor = fecha.Substring(0, 2) + "-" + fecha.Substring(3,2) + "-" + fecha.Substring(6);
        }
    }
}
