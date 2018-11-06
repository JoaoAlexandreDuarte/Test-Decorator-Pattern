namespace GunDecorations {
    public class MachineGun : Gun {
        public override int AmmoCapacity { get; } = 100;
        public override float NoiseLevel { get; } = 40;

        public override string Render() {
            return "MachineGun";
        }
    }
}
