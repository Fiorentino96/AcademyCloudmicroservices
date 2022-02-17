namespace Shapes
{

    public interface IRettangolo
    {
        float Base { get; set; }

        float Altezza { get; set; }

        float Area { get;}

        float Perimetro { get; }

        System.Drawing.Color Colore { get; }
    }

}