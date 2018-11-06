using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunDecorations {
    public class GunSilencer : GunDecorator {
        public override float NoiseLevel {
            get {
                return base.Gun.NoiseLevel * 0.3f;
            }
        }

        public GunSilencer(Gun gun) : base(gun) {

        }

        public override string Render() {
            return base.Gun.Render() + " GunSilencer";
        }
    }
}
