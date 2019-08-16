using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    class Card
    {
        //Esta es mi clase padre y ahora tengo que ver que tienen en comun las clases Special y Combat

        private string name;
        private string type;
        private string effect;


        public Card(string name, string type, string effect, int attackPoints, bool hero)
        {
            Name = name;
            Type = type;
            Effect = effect;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }

    }
}
