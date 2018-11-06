namespace GunDecorations {
    public class ShotGun : Gun {
        public override int AmmoCapacity { get; } = 15;
        public override float NoiseLevel { get; } = 100;

        public override string Render() {
            return "ShotGun";
        }
    }
}
