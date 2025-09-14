
namespace IMCTercerIntento.Models
{
    public class ImcCalculadora
    {
        public double weight { get; set; }
        public double height { get; set; }


        public ImcCalculadora(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }

    }
}
