using TMPS_lab1.Factory.Abstracts;

namespace TMPS_lab1.Factory.Domain
{
    public class Footwear : Product
    {
        public Footwear(int id, string name, string description, double price) : base(id, name, description, price)
        {
        }
    }
}