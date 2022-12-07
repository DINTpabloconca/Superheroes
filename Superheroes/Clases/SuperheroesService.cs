using Superheroes.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class SuperheroesService
    {
     public ObservableCollection<Superheroe> ObtenerSuperheroes()
        {
            return Superheroe.GetSamples();
        }
    }
}
