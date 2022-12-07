using Microsoft.Toolkit.Mvvm.ComponentModel;
using Superheroes.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.VistaModelo
{
    class MainWindowVM : ObservableObject
    {
        private Superheroe personaje;

        public Superheroe Personaje
        {
            get { return personaje; }
            set
            {
                personaje = value;
                SetProperty(ref personaje, value);
            }
        }

        private int posicion;

        public int Posicion
        {
            get { return posicion; }
            set
            {
                posicion = value;
                SetProperty(ref posicion, value);
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                SetProperty(ref total, value);
            }
        }
        private SuperheroesService servicio_Heroes;
        ObservableCollection<Superheroe> listaSuperheroes;
        private DialogosService servicio_Dialogo;
        public MainWindowVM()
        {
            servicio_Dialogo = new DialogosService();
            servicio_Heroes = new SuperheroesService();
            listaSuperheroes = servicio_Heroes.ObtenerSuperheroes();
            this.Personaje = listaSuperheroes[0];
            this.Posicion = 1;
            this.Total = listaSuperheroes.Count;
        }
        public void Avanzar()
        {
            if (Posicion < Total)
            {
                Posicion++;
                Personaje = listaSuperheroes[Posicion - 1];
            }
            else
            {
                servicio_Dialogo.MostrarMensaje("Has llegado al final");
            }

        }
        public void Retroceder()
        {
            if (Posicion > 1)
            {
                Posicion--;
                Personaje = listaSuperheroes[Posicion - 1];
            }
            else
            {
                servicio_Dialogo.MostrarMensaje("Has llegado al principio");
            }
        }


    }

}