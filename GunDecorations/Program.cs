using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunDecorations {
    class Program {
        static void Main(string[] args) {
            Gun machinegun = new MachineGun();
            Gun shotgun = new ShotGun();
            GunClip clipMachineGun = new GunClip(machinegun);

            Console.WriteLine(clipMachineGun.Render());
            clipMachineGun.Fire();
            Console.WriteLine("\n");
            Console.WriteLine(shotgun.Render());
            shotgun.Fire();
        }
    }
}
