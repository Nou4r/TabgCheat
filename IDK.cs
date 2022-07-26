using Landfall.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAssembly
{
    class IDK
    {
        public PhotonServerHandler server;

        public static Player player;
        public static void Supergun(ref Gun gun)
        {
            gun.bullets = 65535;
            gun.bulletsInMag = 65535;
            gun.extraSpread = 0f;
            gun.hasFullAuto = true;
            gun.hipSpreadValue = 0f;
            gun.projectileRecoilMultiplier = 0f;
            gun.rateOfFire = 0.025f;
            gun.currentFireMode = 2; // Full auto.

             UnityEngine.Object.Destroy(gun.GetComponent<Recoil>());
        }
        public static void UnlimtedAmmo(ref Gun gun)
        {
            gun.bulletsInMag = 65535;
            gun.bullets = 65535;
        }
        public static void NoRecoilBye(ref Gun gun)
        {
            UnityEngine.Object.Destroy(gun.GetComponent<Recoil>());
        }
        public static void RapidFire(ref Gun gun)
        {
            gun.rateOfFire = 0.025f;
            gun.currentFireMode = 2; // Full auto.
        }
        public static void ByeReloadTime(ref Gun gun)
        {
            gun.reloadTime = 0f;
            gun.ReloadEventDelayNumber = 0f;
        }

    }
}
