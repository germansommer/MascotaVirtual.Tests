using System;
using System.Collections.Generic;
using System.Text;

namespace MascotaVirtual.Tests
{
    class Mascota
    {
        public Boolean EstaDespierto { set; get; }
        public Boolean EstaLleno { set; get; }

        public Boolean PuedeComer()
        {
            if (this.EstaLleno == true)
            {
                return false;
            }
            
            if (this.EstaDespierto == false)
            {
                return false;
            }

            return true;
        }

        
        public Boolean PuedeDormir()
        {
            if (this.EstaDespierto == true)
            {
                return false;
            }
            return true;
        }

        public Boolean PuedeDespertar()
        {
            if (this.EstaDespierto == true)
            {
                return false;
            }
            return true;
        }

        public Boolean PuedeJugar()
        {
            if (this.EstaLleno == false)
            {
                return false;
            }

            if(this.EstaDespierto == false)
            {
                return false;
            }

            return true;
        }

    }
}
