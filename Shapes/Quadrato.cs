namespace Shapes
{
    // tutto in metri
    public class Quadrato : Rettangolo, IRettangolo
    {

        private float lato;

        public override float Base
        {
            get
            {
                return Lato;
            }
            set
            {
                Lato = value;
                base.Base = Lato;
            }
        }

        public override float Altezza
        {
            get
            {
                return Lato;
            }
            set
            {
                Lato = value;
                base.Altezza = Lato;
            }
        }



        public float Lato
        {
            get
            {
                // posso trasformare
                return lato;
            }
            set
            {
                // posso trasformare o validare
                lato = value;
            }
        }
    }

}