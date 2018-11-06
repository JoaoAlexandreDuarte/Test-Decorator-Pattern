namespace GunDecorations {
    public class GunClip : GunDecorator {
        public override int AmmoCapacity {
            get {
                return base.Gun.AmmoCapacity + 100;
            }
        }

        public GunClip(Gun gun) : base(gun) {
        }

        public override string Render() {
            return base.Gun.Render() + " GunClip";
        }
    }
}
