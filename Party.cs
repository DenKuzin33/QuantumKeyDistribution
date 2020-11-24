using System;

namespace QuantumKeyDistribution
{
    class Party
    {
        private Random rnd = new Random();
        public Photon[] keys;
        public Party()
        {

        }
        public Party(Photon[] keys)
        {
            this.keys = keys;
        }

        public void MeasureAndPrint(Photon[] photons)
        {
            foreach (var photon in photons)
            {
                Console.WriteLine(photon.Measure((Photon.Basis)(rnd.Next(1, 3) * 90)));
            }
        }
    }
}
