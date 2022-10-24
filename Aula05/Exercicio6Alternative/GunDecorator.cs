using System;

namespace GunDecorations
{
    public abstract class GunDecorator : IGun
    {
        private IGun decoratedGun;

        public virtual int AmmoCapacity =>
            decoratedGun.AmmoCapacity;
        public virtual float NoiseLevel =>
            decoratedGun.NoiseLevel;

        public void Fire()
        {
            Console.Write($"Ammo = {AmmoCapacity} | ");
            Console.WriteLine($"Noise = {NoiseLevel}");
        }
        
        public GunDecorator(IGun decoratedGun)
        {
            this.decoratedGun = decoratedGun;
        }
        
    }
}