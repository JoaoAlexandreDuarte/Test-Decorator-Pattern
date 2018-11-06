using System;

namespace GunDecorations {
    public abstract class Gun {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }

        public void Fire() {
            Console.WriteLine("MaxAmmo: " + AmmoCapacity + "\nNoiseLevel: "
                + NoiseLevel);
        }

        public abstract string Render();
    }
}
