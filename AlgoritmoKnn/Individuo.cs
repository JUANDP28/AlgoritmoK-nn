using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmoKnn {

    class Individuo {

        private String nombre;
        private Double fila1;
        private Double fila2;
        private Double fila3;
        private Double fila4;

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
            this.fila1 = fila1;
            this.fila2 = fila2;
            this.fila3 = fila3;
            this.fila4 = fila4;
        }

        /// <summary>
        /// Metodo que obtiene el nombre
        /// </summary>
        /// <returns>Nombre de la clase</returns>
        public String getNombre () {
            return this.nombre;
        }

        /// <summary>
        /// Metodo que obtiene el valor de la fila1
        /// </summary>
        /// <returns>valor de la fila1</returns>
        public Double getFila1 () {
            return this.fila1;
        }

        /// <summary>
        /// Metodo que obtiene el valor de la fila2
        /// </summary>
        /// <returns>valor de la fila2</returns>
        public Double getFila2 () {
            return this.fila2;
        }

        /// <summary>
        /// Metodo que obtiene el valor de la fila3
        /// </summary>
        /// <returns>valor de la fila3</returns>
        public Double getFila3 () {
            return this.fila3;
        }

        /// <summary>
        /// Metodo que obtiene el valor de la fila4
        /// </summary>
        /// <returns>valor de la fila4</returns>
        public Double getFila4 () {
            return this.fila4;
        }
    }
}
