using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double n1, n2, n3, nf;

        public double NotaFinal()
        {
            return n1 + n2 + n3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
