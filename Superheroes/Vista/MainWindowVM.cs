using Superheroes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.VistaModelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Superheroe personaje;

        public Superheroe Personaje
        {
            get { return personaje; }
            set
            {
                personaje = value;
                this.NotifyPropertyChanged("Personaje");
            }
        }

        private int posicion;

        public int Posicion
        {
            get { return posicion; }
            set
            {
                posicion = value;
                this.NotifyPropertyChanged("Posicion");
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                this.NotifyPropertyChanged("Total");
            }
        }

        List<Superheroe> listaSuperheroes = Superheroe.GetSamples();
        public MainWindowVM()
        {
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

        }
        public void Retroceder()
        {
            if (Posicion > 1)
            {
                Posicion--;
                Personaje = listaSuperheroes[Posicion - 1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}