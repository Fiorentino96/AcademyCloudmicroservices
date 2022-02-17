namespace Shapes
{
    // tutto in metri
    public class Rettangolo : IRettangolo
    {
        private float baseRettangolo;
        private float altezzaRettangolo;

        public Rettangolo()
        {
            // inizializzo i dati
        }

        public virtual float Base
        {
            get
            {
                return baseRettangolo;
            }
            set
            {
                // potrei validare o trasformare il valore passato
                baseRettangolo = value;
            }
        }
        public virtual float Altezza
        {
            get
            {
                return altezzaRettangolo;
            }
            set
            {
                altezzaRettangolo = value;
            }
        }
        public float Area
        {
            get
            {
                return Base * Altezza;
            }
        }
        public float Perimetro
        {
            get
            {
                return (Base * 2) + (Altezza * 2);
            }
        }

        public System.Drawing.Color Colore
        {
            get
            {
                return System.Drawing.Color.Blue;
            }
        }

    }

}