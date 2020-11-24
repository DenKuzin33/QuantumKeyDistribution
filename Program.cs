using System;

namespace QuantumKeyDistribution
{
    class Program
    {
        static void Main()
        {
            Party alice = new Party(new Photon[] {
                new Photon(0, Photon.Basis.Horizontal),
                new Photon(1, Photon.Basis.Vertical),
                new Photon(1, Photon.Basis.Vertical),
                new Photon(0, Photon.Basis.Horizontal),
                new Photon(0, Photon.Basis.Vertical),
                new Photon(1, Photon.Basis.Horizontal),
                new Photon(0, Photon.Basis.Vertical),
                new Photon(1, Photon.Basis.Horizontal)
            });

            Party eve = new Party();
            Console.WriteLine("Eve's measurement:");
            eve.MeasureAndPrint(alice.keys);
            Console.WriteLine();
            Party bob = new Party();
            Console.WriteLine("Bob's measurement:");
            bob.MeasureAndPrint(alice.keys);
            Console.ReadKey();
        }
    }
}
