using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEjercicio2
{
    class Lista
    {
        public class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz, fondo;

        public Lista()
        {
            raiz = null;
            fondo = null;
        }

        private bool Vacia()
        {

            if (raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Insertar(int info)
        {

            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }
        }

        public int Extraer()
        {
            if (!Vacia())
            {
                int informacion = raiz.info;
                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig;
                }
                return informacion;
            }
            else
            {
                return 0;
            }
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de todos los elementos de la cola.");
            while (reco != null)
            {
                Console.Write(reco.info + "->");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        //Esto servira para verificar cuantos elementos habra en la cola
        public int CantidaddeElementos()
        {
            Nodo reco = raiz;
            int cantidad = 0;
            while (reco != null)
            {
                reco = reco.sig;
                cantidad++;
            }
            return cantidad;
        }

        //Esto metodo verificara que este de forma Ascendente
        private bool OrdenarDescendente()
        {
            int numeroA, numeroS;
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.sig != null)
                {
                    numeroA = reco.sig.info;
                    numeroS = reco.info;
                    if (numeroA > numeroS)
                    {
                        return false;
                    }
                }
                reco = reco.sig;
            }
            return true;
        }

        //Esto metodo ordenara de forma Descente
        public void Descente()
        {
            if (!Vacia())
            {
                Nodo reco;
                int numeroA, numeroS;
                while (!OrdenarDescendente())
                {
                    reco = raiz;
                    while (reco != null)
                    {
                        if (reco.sig != null)
                        {
                            numeroA = reco.sig.info;
                            numeroS = reco.info;
                            if (numeroA > numeroS)
                            {
                                reco.sig.info = numeroS;
                                reco.info = numeroA;
                            }
                        }
                        reco = reco.sig;
                    }
                    Imprimir();
                }
            }
        }

        //Este metodo verificara que este de forma Ascendente
        private bool OrdenarAscendente()
        {
            int numeroA, numeroS;
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.sig != null)
                {
                    numeroA = reco.info;
                    numeroS = reco.sig.info;
                    if (numeroA > numeroS)
                    {
                        return false;
                    }
                }
                reco = reco.sig;
            }
            return true;
        }

        //Este metodo ordena de forma Ascendente
        public void Ascendente()
        {
            if (!Vacia())
            {
                Nodo reco;
                int numeroA, numeroS;
                while (!OrdenarAscendente())
                {
                    reco = raiz;
                    while (reco != null)
                    {
                        if (reco.sig != null)
                        {
                            numeroA = reco.info;
                            numeroS = reco.sig.info;
                            if (numeroA > numeroS)
                            {
                                reco.info = numeroS;
                                reco.sig.info = numeroA;
                            }
                        }
                        reco = reco.sig;
                    }
                    Imprimir();
                }
            }
        }


    }
}
