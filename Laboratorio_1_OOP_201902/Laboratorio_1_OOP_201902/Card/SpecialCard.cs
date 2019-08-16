using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    class SpecialCard : Card
    {

        private string buffType;
        

        //Constructor
        public SpecialCard(Nullable BuffType)
        {
           BuffType = null;
        }


        }
        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }

    }
}
