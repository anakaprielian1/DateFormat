using System;

namespace Library
{
    // se creo esta clase para cumplir con el ppio de responsabilidad unica
    public class Format
    {
        public String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3,2) + "-" + year.Substring(0,2);
        }
    }
}
