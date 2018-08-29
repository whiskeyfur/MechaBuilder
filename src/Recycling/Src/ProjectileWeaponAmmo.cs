using MechBuilder.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechBuilder.Src.Systems {
    public class ProjectileAmmo : BaseAmmo {
        private ProjectileWeapon AssignedWeapon;
        public ProjectileAmmo(ProjectileWeapon assignedWeapon) {
            AssignedWeapon = assignedWeapon;
        }
        public int GetDamageRating() {
            return AssignedWeapon.DamageRating;
        }
        public double GetParentCost() {
            return AssignedWeapon.GetBaseCost();
        }
        public int MagazineSize = 10;
        public Dictionary<string, string> AmmoModifiers = new Dictionary<string, string>
        {
            {"AmmoType", "High Explosive" },
            {"Blast Radius","None"}
        };
        [FlagsAttribute]
        public enum AmmoOptions : int {
            None = 0,
            Normal = 1,
            Tracer = 2,
            Tangler = 4,
            ArmorPiercing = 8,
            Disruptor = 16,
            Incendiary = 32,
            Shock = 64,
            ShockAdded = 65,
            ScatterShot = 128,
            Nuclear = 256,
            Kinetic = 512
        }
        public AmmoOptions Options = new AmmoOptions { };

        public double GetWeight() {
            return (double)GetStructure();

        }
        public int GetStructure() {
            return (int)(0.01 * (double)MagazineSize * GetParentCost());
        }
        public double GetCost() {
            double x = GetStructure();
            if (AmmoModifiers["AmmoType"] != "High Explosive") {
                x *= 0.5;
                Options = AmmoOptions.None;
            }

            if ((Options & AmmoOptions.Tangler) > 0) x *= 3.0;
            if ((Options & AmmoOptions.Tracer) > 0) x *= 3.0;
            if ((Options & AmmoOptions.Kinetic) > 0) x *= 3.0;
            if ((Options & AmmoOptions.ArmorPiercing) > 0) x *= 4.0;
            if ((Options & AmmoOptions.Disruptor) > 0) x *= 4.0;
            if ((Options & AmmoOptions.ShockAdded) > 0) x *= 6.0;
            else if ((Options & AmmoOptions.Shock) > 0) x *= 4.0;
            if ((Options & AmmoOptions.Incendiary) > 0) x *= 4.0;
            if ((Options & AmmoOptions.ScatterShot) > 0) x *= 5.0;
            if ((Options & AmmoOptions.Nuclear) > 0) x *= 1000.0;
            switch (AmmoModifiers["Blast Radius"]) {
                case ("None"):
                    break;
                case ("1"):
                    x *= 6.0;
                    break;
                case ("2"):
                    x *= 8.0;
                    break;
                case ("3"):
                    x *= 10.0;
                    break;
                case ("4"):
                    x *= 12.0;
                    break;
                case ("5"):
                    x *= 14.0;
                    break;
                default: break;
            }
            return x;
        }
    }
}
