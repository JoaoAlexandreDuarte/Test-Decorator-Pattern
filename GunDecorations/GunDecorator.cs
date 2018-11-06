namespace GunDecorations {
    public abstract class GunDecorator : Gun {
        public Gun Gun { get; }
        public override int AmmoCapacity {
            get {
                return Gun.AmmoCapacity;
            }
        }
        public override float NoiseLevel {
            get {
                return Gun.NoiseLevel;
            }
        }

        protected GunDecorator(Gun gun) {
            Gun = gun;
        }
    }
}
