using System;
using System.Collections.Generic;

namespace AlgoritmoKnn {

    class Program {

        List<Individuo> iris = new List<Individuo>();
        List<Individuo> entrenamiento = new List<Individuo>();
        List<Individuo> prueba = new List<Individuo>();

        /// <summary>
        /// Metodo que carga la base de datos iris
        /// </summary>
        public void CargarDatos () {

            iris.Add(new Individuo("Setosa", 5.1, 3.5, 1.4, 0.2));
            iris.Add(new Individuo("Setosa", 4.9, 3.0, 1.4, 0.2));
            iris.Add(new Individuo("Setosa", 4.7, 3.2, 1.3, 0.2));
            iris.Add(new Individuo("Setosa", 4.6, 3.1, 1.5, 0.2));
            iris.Add(new Individuo("Setosa", 5.0, 3.6, 1.4, 0.2));
            iris.Add(new Individuo("Setosa", 5.4, 3.9, 1.7, 0.4));
            iris.Add(new Individuo("Setosa", 4.6, 3.4, 1.4, 0.3));
            iris.Add(new Individuo("Setosa", 5.0, 3.4, 1.5, 0.2));
            iris.Add(new Individuo("Setosa", 4.4, 2.9, 1.4, 0.2));
            iris.Add(new Individuo("Setosa", 4.9, 3.1, 1.5, 0.1));
            iris.Add(new Individuo("Setosa", 5.4, 3.7, 1.5, 0.2));
            iris.Add(new Individuo("Setosa", 4.8, 3.4, 1.6, 0.2));
            iris.Add(new Individuo("Setosa", 4.8, 3.0, 1.4, 0.1));
            iris.Add(new Individuo("Setosa", 4.3, 3.0, 1.1, 0.1));
            iris.Add(new Individuo("Setosa", 5.8, 4.0, 1.2, 0.2));
            iris.Add(new Individuo("Setosa", 5.7, 4.4, 1.5, 0.4));
            iris.Add(new Individuo("Setosa", 5.4, 3.9, 1.3, 0.4));
            iris.Add(new Individuo("Setosa", 5.1, 3.5, 1.4, 0.3));
            iris.Add(new Individuo("Setosa", 5.7, 3.8, 1.7, 0.3));
            iris.Add(new Individuo("Setosa", 5.1, 3.8, 1.5, 0.3));
            iris.Add(new Individuo("Setosa", 5.4, 3.4, 1.7, 0.2));
            iris.Add(new Individuo("Setosa", 5.1, 3.7, 1.5, 0.4));
            iris.Add(new Individuo("Setosa", 4.6, 3.6, 1.0, 0.2));
            iris.Add(new Individuo("Setosa", 5.1, 3.3, 1.7, 0.5));
            iris.Add(new Individuo("Setosa", 4.8, 3.4, 1.9, 0.2));
            iris.Add(new Individuo("Setosa", 5.0, 3.0, 1.6, 0.2));
            iris.Add(new Individuo("Setosa", 5.0, 3.4, 1.6, 0.4));
            iris.Add(new Individuo("Setosa", 5.2, 3.5, 1.5, 0.2));
            iris.Add(new Individuo("Setosa", 5.2, 3.4, 1.4, 0.2));
            iris.Add(new Individuo("Setosa", 4.7, 3.2, 1.6, 0.2));
            iris.Add(new Individuo("Setosa", 4.8, 3.1, 1.6, 0.2));
            iris.Add(new Individuo("Setosa", 5.4, 3.4, 1.5, 0.4));
            iris.Add(new Individuo("Setosa", 5.2, 4.1, 1.5, 0.1));
            iris.Add(new Individuo("Setosa", 5.5, 4.2, 1.4, 0.2));
            iris.Add(new Individuo("Setosa", 4.9, 3.1, 1.5, 0.1));
            iris.Add(new Individuo("Setosa", 5.0, 3.2, 1.2, 0.2));
            iris.Add(new Individuo("Setosa", 5.5, 3.5, 1.3, 0.2));
            iris.Add(new Individuo("Setosa", 4.9, 3.1, 1.5, 0.1));
            iris.Add(new Individuo("Setosa", 4.4, 3.0, 1.3, 0.2));
            iris.Add(new Individuo("Setosa", 5.1, 3.4, 1.5, 0.2));
            iris.Add(new Individuo("Setosa", 5.0, 3.5, 1.3, 0.3));
            iris.Add(new Individuo("Setosa", 4.5, 2.3, 1.3, 0.3));
            iris.Add(new Individuo("Setosa", 4.4, 3.2, 1.3, 0.2));
            iris.Add(new Individuo("Setosa", 5.0, 3.5, 1.6, 0.6));
            iris.Add(new Individuo("Setosa", 5.1, 3.8, 1.9, 0.4));
            iris.Add(new Individuo("Setosa", 4.8, 3.0, 1.4, 0.3));
            iris.Add(new Individuo("Setosa", 5.1, 3.8, 1.6, 0.2));
            iris.Add(new Individuo("Setosa", 4.6, 3.2, 1.4, 0.2));
            iris.Add(new Individuo("Setosa", 5.3, 3.7, 1.5, 0.2));
            iris.Add(new Individuo("Setosa", 5.0, 3.3, 1.4, 0.2));
            iris.Add(new Individuo("Versicolor", 7.0, 3.2, 4.7, 1.4));
            iris.Add(new Individuo("Versicolor", 6.4, 3.2, 4.5, 1.5));
            iris.Add(new Individuo("Versicolor", 6.9, 3.1, 4.9, 1.5));
            iris.Add(new Individuo("Versicolor", 5.5, 2.3, 4.0, 1.3));
            iris.Add(new Individuo("Versicolor", 6.5, 2.8, 4.6, 1.5));
            iris.Add(new Individuo("Versicolor", 5.7, 2.8, 4.5, 1.3));
            iris.Add(new Individuo("Versicolor", 6.3, 3.3, 4.7, 1.6));
            iris.Add(new Individuo("Versicolor", 4.9, 2.4, 3.3, 1.0));
            iris.Add(new Individuo("Versicolor", 6.6, 2.9, 4.6, 1.3));
            iris.Add(new Individuo("Versicolor", 5.2, 2.7, 3.9, 1.4));
            iris.Add(new Individuo("Versicolor", 5.0, 2.0, 3.5, 1.0));
            iris.Add(new Individuo("Versicolor", 5.9, 3.0, 4.2, 1.5));
            iris.Add(new Individuo("Versicolor", 6.0, 2.2, 4.0, 1.0));
            iris.Add(new Individuo("Versicolor", 6.1, 2.9, 4.7, 1.4));
            iris.Add(new Individuo("Versicolor", 5.6, 2.9, 3.6, 1.3));
            iris.Add(new Individuo("Versicolor", 6.7, 3.1, 4.4, 1.4));
            iris.Add(new Individuo("Versicolor", 5.6, 3.0, 4.5, 1.5));
            iris.Add(new Individuo("Versicolor", 5.8, 2.7, 4.1, 1.0));
            iris.Add(new Individuo("Versicolor", 6.2, 2.2, 4.5, 1.5));
            iris.Add(new Individuo("Versicolor", 5.6, 2.5, 3.9, 1.1));
            iris.Add(new Individuo("Versicolor", 5.9, 3.2, 4.8, 1.8));
            iris.Add(new Individuo("Versicolor", 6.1, 2.8, 4.0, 1.3));
            iris.Add(new Individuo("Versicolor", 6.3, 2.5, 4.9, 1.5));
            iris.Add(new Individuo("Versicolor", 6.1, 2.8, 4.7, 1.2));
            iris.Add(new Individuo("Versicolor", 6.4, 2.9, 4.3, 1.3));
            iris.Add(new Individuo("Versicolor", 6.6, 3.0, 4.4, 1.4));
            iris.Add(new Individuo("Versicolor", 6.8, 2.8, 4.8, 1.4));
            iris.Add(new Individuo("Versicolor", 6.7, 3.0, 5.0, 1.7));
            iris.Add(new Individuo("Versicolor", 6.0, 2.9, 4.5, 1.5));
            iris.Add(new Individuo("Versicolor", 5.7, 2.6, 3.5, 1.0));
            iris.Add(new Individuo("Versicolor", 5.5, 2.4, 3.8, 1.1));
            iris.Add(new Individuo("Versicolor", 5.5, 2.4, 3.7, 1.0));
            iris.Add(new Individuo("Versicolor", 5.8, 2.7, 3.9, 1.2));
            iris.Add(new Individuo("Versicolor", 6.0, 2.7, 5.1, 1.6));
            iris.Add(new Individuo("Versicolor", 5.4, 3.0, 4.5, 1.5));
            iris.Add(new Individuo("Versicolor", 6.0, 3.4, 4.5, 1.6));
            iris.Add(new Individuo("Versicolor", 6.7, 3.1, 4.7, 1.5));
            iris.Add(new Individuo("Versicolor", 6.3, 2.3, 4.4, 1.3));
            iris.Add(new Individuo("Versicolor", 5.6, 3.0, 4.1, 1.3));
            iris.Add(new Individuo("Versicolor", 5.5, 2.5, 4.0, 1.3));
            iris.Add(new Individuo("Versicolor", 5.5, 2.6, 4.4, 1.2));
            iris.Add(new Individuo("Versicolor", 6.1, 3.0, 4.6, 1.4));
            iris.Add(new Individuo("Versicolor", 5.8, 2.6, 4.0, 1.2));
            iris.Add(new Individuo("Versicolor", 5.0, 2.3, 3.3, 1.0));
            iris.Add(new Individuo("Versicolor", 5.6, 2.7, 4.2, 1.3));
            iris.Add(new Individuo("Versicolor", 5.7, 3.0, 4.2, 1.2));
            iris.Add(new Individuo("Versicolor", 5.7, 2.9, 4.2, 1.3));
            iris.Add(new Individuo("Versicolor", 6.2, 2.9, 4.3, 1.3));
            iris.Add(new Individuo("Versicolor", 5.1, 2.5, 3.0, 1.1));
            iris.Add(new Individuo("Versicolor", 5.7, 2.8, 4.1, 1.3));
            iris.Add(new Individuo("Virginica", 6.3, 3.3, 6.0, 2.5));
            iris.Add(new Individuo("Virginica", 5.8, 2.7, 5.1, 1.9));
            iris.Add(new Individuo("Virginica", 7.1, 3.0, 5.9, 2.1));
            iris.Add(new Individuo("Virginica", 6.3, 2.9, 5.6, 1.8));
            iris.Add(new Individuo("Virginica", 6.5, 3.0, 5.8, 2.2));
            iris.Add(new Individuo("Virginica", 7.6, 3.0, 6.6, 2.1));
            iris.Add(new Individuo("Virginica", 4.9, 2.5, 4.5, 1.7));
            iris.Add(new Individuo("Virginica", 7.3, 2.9, 6.3, 1.8));
            iris.Add(new Individuo("Virginica", 6.7, 2.5, 5.8, 1.8));
            iris.Add(new Individuo("Virginica", 7.2, 3.6, 6.1, 2.5));
            iris.Add(new Individuo("Virginica", 6.5, 3.2, 5.1, 2.0));
            iris.Add(new Individuo("Virginica", 6.4, 2.7, 5.3, 1.9));
            iris.Add(new Individuo("Virginica", 6.8, 3.0, 5.5, 2.1));
            iris.Add(new Individuo("Virginica", 5.7, 2.5, 5.0, 2.0));
            iris.Add(new Individuo("Virginica", 5.8, 2.8, 5.1, 2.4));
            iris.Add(new Individuo("Virginica", 6.4, 3.2, 5.3, 2.3));
            iris.Add(new Individuo("Virginica", 6.5, 3.0, 5.5, 1.8));
            iris.Add(new Individuo("Virginica", 7.7, 3.8, 6.7, 2.2));
            iris.Add(new Individuo("Virginica", 7.7, 2.6, 6.9, 2.3));
            iris.Add(new Individuo("Virginica", 6.0, 2.2, 5.0, 1.5));
            iris.Add(new Individuo("Virginica", 6.9, 3.2, 5.7, 2.3));
            iris.Add(new Individuo("Virginica", 5.6, 2.8, 4.9, 2.0));
            iris.Add(new Individuo("Virginica", 7.7, 2.8, 6.7, 2.0));
            iris.Add(new Individuo("Virginica", 6.3, 2.7, 4.9, 1.8));
            iris.Add(new Individuo("Virginica", 6.7, 3.3, 5.7, 2.1));
            iris.Add(new Individuo("Virginica", 7.2, 3.2, 6.0, 1.8));
            iris.Add(new Individuo("Virginica", 6.2, 2.8, 4.8, 1.8));
            iris.Add(new Individuo("Virginica", 6.1, 3.0, 4.9, 1.8));
            iris.Add(new Individuo("Virginica", 6.4, 2.8, 5.6, 2.1));
            iris.Add(new Individuo("Virginica", 7.2, 3.0, 5.8, 1.6));
            iris.Add(new Individuo("Virginica", 7.4, 2.8, 6.1, 1.9));
            iris.Add(new Individuo("Virginica", 7.9, 3.8, 6.4, 2.0));
            iris.Add(new Individuo("Virginica", 6.4, 2.8, 5.6, 2.2));
            iris.Add(new Individuo("Virginica", 6.3, 2.8, 5.1, 1.5));
            iris.Add(new Individuo("Virginica", 6.1, 2.6, 5.6, 1.4));
            iris.Add(new Individuo("Virginica", 7.7, 3.0, 6.1, 2.3));
            iris.Add(new Individuo("Virginica", 6.3, 3.4, 5.6, 2.4));
            iris.Add(new Individuo("Virginica", 6.4, 3.1, 5.5, 1.8));
            iris.Add(new Individuo("Virginica", 6.0, 3.0, 4.8, 1.8));
            iris.Add(new Individuo("Virginica", 6.9, 3.1, 5.4, 2.1));
            iris.Add(new Individuo("Virginica", 6.7, 3.1, 5.6, 2.4));
            iris.Add(new Individuo("Virginica", 6.9, 3.1, 5.1, 2.3));
            iris.Add(new Individuo("Virginica", 5.8, 2.7, 5.1, 1.9));
            iris.Add(new Individuo("Virginica", 6.8, 3.2, 5.9, 2.3));
            iris.Add(new Individuo("Virginica", 6.7, 3.3, 5.7, 2.5));
            iris.Add(new Individuo("Virginica", 6.7, 3.0, 5.2, 2.3));
            iris.Add(new Individuo("Virginica", 6.3, 2.5, 5.0, 1.9));
            iris.Add(new Individuo("Virginica", 6.5, 3.0, 5.2, 2.0));
            iris.Add(new Individuo("Virginica", 6.2, 3.4, 5.4, 2.3));
            iris.Add(new Individuo("Virginica", 5.9, 3.0, 5.1, 1.8));
        }

        /// <summary>
        /// Metodod que seleeciona los elementos para el entrenamiento
        /// </summary>
        public void SeleccionElementos () {

            while (entrenamiento.Count < 100) {

                int posicion = NumeroRandom(1, 151);

                if (!entrenamiento.Contains(ObtenerIndividuo(iris, posicion))) {

                    entrenamiento.Add(ObtenerIndividuo(iris, posicion));
                }
            }

            LlenarPrueba();
        }

        /// <summary>
        /// Metodo que optiene un numero random dentro del intervalo
        /// </summary>
        /// <param name="minimo">Valor minimo del rango</param>
        /// <param name="maximo">Valor maximo del rango</param>
        /// <returns>Valor aleatorio dentro del rango</returns>
        public int NumeroRandom (int minimo, int maximo) {

            Random random = new Random();
            return random.Next(minimo, maximo);
        }

        /// <summary>
        /// Metodo que obtiene un individuo de la lista proporcionada
        /// </summary>
        /// <param name="lista">Lista de donde se obtendra el individuo</param>
        /// <param name="posicion">Posición del individuo que se desea</param>
        /// <returns>El individuo deseado</returns>
        public Individuo ObtenerIndividuo(List<Individuo> lista, int posicion) {

            int contador = 1;

            foreach (Individuo elemento in lista) {

                if (contador == posicion) {

                    return elemento;

                } else {

                    contador++;
                }
            }

            return null;
        }

        /// <summary>
        /// Metodod que introduce los registros restantes al espacio de prueba
        /// </summary>
        public void LlenarPrueba () {

            foreach (Individuo elemento in iris) {

                if (!entrenamiento.Contains(elemento)) {
                    prueba.Add(elemento);
                }
            }
        }

        static void Main (string [] args) {

            Console.WriteLine("");
            Console.WriteLine("=============== ALGORITMO K-NN ===============");

            Program algoritmo = new Program();
            algoritmo.CargarDatos();
            Console.WriteLine("");
            Console.WriteLine("Datos Cargados: " + algoritmo.iris.Count);

            algoritmo.SeleccionElementos();
            Console.WriteLine("");
            Console.WriteLine("Entrenamiento: " + algoritmo.entrenamiento.Count);
            Console.WriteLine("Prueba: " + algoritmo.prueba.Count);


        }
    }
}
