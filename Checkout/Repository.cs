using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public interface IRepository
    {
        decimal FindPrice(string code);
    }
    public class Repository : IRepository
    {
        private readonly Dictionary<string, decimal> _catalogue;
        public Repository()
        {
            _catalogue = new Dictionary<string, decimal>()
            {
                {"A", 50},
                {"B", 30},
                {"C", 20},
                {"D", 15},
            };
        }

        public decimal FindPrice(string code)
        {
            return _catalogue[code];
        }
    }
}
