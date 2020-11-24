
namespace QuantumKeyDistribution
{
    class Photon
    {
        private int _value;
        public Photon(int value, Basis basis)
        {
            _value = value ^ (int)basis;
        }

        public int Measure(Basis basis)
        {
            _value ^= (int)basis;
            return _value;
        }

        public enum Basis
        {
            Vertical = 90,
            Horizontal = 180,
        }
    }
}
