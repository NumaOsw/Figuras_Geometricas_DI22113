using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_DI22113
{
    class Prisma: Figura
    {
        public Prisma(float PrtOn) //Dividi esto entres partes agregando el valor de medio y abajo, me guío de un prisma rectangular 
        {
            Lado1 = PrtOn;
        }
        private float PrtMdo;
        private float PrtFnl;

        public float mDo
        {
            set
            {
                if (value < 0) { PrtMdo = 0; } else { PrtMdo = value; }
            }
            get
            {
                return PrtMdo;
            }
        }
        public float fnL
        {
            set
            {
                if (value < 0) { PrtFnl = 0; } else { PrtFnl = value; }
            }
            get
            {
                return PrtFnl;
            }
        }
        public Prisma(float PrtOn, float PrtMdo, float PrtFnl) 
        {
            this.Lado1 = PrtOn;
            this.mDo = PrtMdo;
            this.fnL = PrtFnl;
        }
        public override float area()
        {
            throw new NotImplementedException();
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
