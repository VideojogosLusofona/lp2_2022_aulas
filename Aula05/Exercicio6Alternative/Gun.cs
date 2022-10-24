using System;

namespace GunDecorations
{
    public abstract class Gun : IGun
    {
        public virtual int AmmoCapacity { get; }
        public virtual float NoiseLevel { get; }

        public void Fire()
        {
            Console.Write($"Ammo = {AmmoCapacity} | ");
            Console.WriteLine($"Noise = {NoiseLevel}");
        }

        public Gun(int ammoCapacity, float noiseLevel)
        {
            AmmoCapacity = ammoCapacity;
            NoiseLevel = noiseLevel;
        }
    }
}