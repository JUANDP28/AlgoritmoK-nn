using System;

namespace AlgoritmoKnn {

    class Individuo {

        public String nombre;
        public Double[] filas;
        public Double distancia;

        /// <summary>
        /// Contructor de la clase Individuo
        /// </summary>
        /// <param name="nombre">Clase del registro</param>
        /// <param name="fila1">valor 1</param>
        /// <param name="fila2">valor 2</param>
        /// <param name="fila3">valor 3</param>
        /// <param name="fila4">valor 4</param>
        public Individuo (String nombre, Double fila1, Double fila2, Double fila3, Double fila4) {

            this.nombre = nombre;
            this.filas = new Double[4] {fila1, fila2, fila3, fila4};
            this.distancia = 0.0;
        }
    }
}
