namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        public override float NoiseLevel =>
            base.NoiseLevel * 0.20f;

        public GunSilencer(IGun decoratedGun) : base(decoratedGun)
        { }
    }
}