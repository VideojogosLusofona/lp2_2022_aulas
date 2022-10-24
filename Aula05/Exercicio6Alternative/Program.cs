using System;

namespace GunDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            IGun shotgun = new ShotGun();
            IGun mGun = new MachineGun();

            IGun shotgunAll = new GunClip(
                new GunSilencer(shotgun));

            mGun.Fire();
            shotgun.Fire();
            shotgunAll.Fire();
        }
    }
}
