using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Log1
{
    internal class Jugador
    {
        String nombre;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        String amigoSecreto;

        public Jugador(string nombre, string correo, string endulzadaIdeal, string regaloIdeal, string amigoSecreto)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.endulzadaIdeal = endulzadaIdeal;
            this.regaloIdeal = regaloIdeal;
            this.amigoSecreto = amigoSecreto;
        }
    }

}
