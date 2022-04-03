using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class MagicBall
    {
        static String[] _listaDeRespuestas = { "Es cierto", "Es decididamente as", "Sin lugar a dudas", "Sí, definitivamente", "Puedes confiar en ello",
                                        "Como yo lo veo, sí", "Lo más probable","Perspectiva buena","Sí" , "Las señales apuntan a que sí",
                                        "Respuesta confusa, vuelve a intentarlo", "Vuelve a preguntar más tarde", "Mejor no decirte ahora","No se puede predecir ahora"," Concéntrate y vuelve a preguntar",
                                         "No cuentes con ello","Mi respuesta es no","Mis fuentes dicen que no","Las perspectivas no son muy buenas","Muy dudoso"};

        public static String devolverRespuesta(String[] lista) {
            Random random = new Random();
            Int64 numeroRandom = random.Next(0, 19);
            String respuesta = lista[numeroRandom];
            return respuesta;
        }


        public static string[] listaDeRespuestas
        {
            get => _listaDeRespuestas;
            set => _listaDeRespuestas = value;
        }

    }
}
