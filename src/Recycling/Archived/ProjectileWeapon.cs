using MechBuilder.Src.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MechBuilder.Lookup;

namespace MechBuilder.Src.Systems {
    public class ProjectileWeapon : BaseRangedWeapon {
        public bool IsHandHeld = false;
        public ProjectileWeapon() {

        }
        public List<ProjectileAmmo> Magazines = new List<ProjectileAmmo> { };
        public List<ProjectileAmmo> MultifeedClips() {
            List<ProjectileAmmo> clips = new List<ProjectileAmmo> { };
            clips = Magazines.GetRange(0, Math.Min(Convert.ToInt32(WeaponModifiers["MultiFeed"]), Magazines.Count));
            return clips;
        }
        public override WeaponTypes GetWeaponType() {
            return WeaponTypes.Projectile;
        }
        public Dictionary<string, double> AccuracyChart = new Dictionary<string, double>
        {
            { "-2", 0.6 },
            { "-1", 0.8 },
            { "0", 1 },
            { "1", 1.5 },
            { "2", 2 },
        };
        public Dictionary<int, int> Rangechart = new Dictionary<int, int>
        {
            { 1, 3 },
            { 2, 4 },
            { 3, 5 },
            { 4, 6 },
            { 5, 7 },
            { 6, 7 },
            { 7, 8 },
            { 8, 8 },
            { 9, 9 },
            { 10, 9 },
            { 11, 10 },
            { 12, 10 },
            { 13, 11 },
            { 14, 11 },
            { 15, 12 },
            { 16, 12 },
            { 17, 12 },
            { 18, 13 },
            { 19, 13 },
            { 20, 13 }
        };

        public Dictionary<object, double> MultifeedChart = new Dictionary<object, double>
        {
            { "1", 1.0 },
            { "2", 1.2 },
            { "3", 1.4 },
            { "4", 1.6 }
        };

        public Dictionary<string, string> WeaponModifiers = new Dictionary<string, string>
        {
            { "MultiFeed", "1"},
            { "BurstValue", "none"},
            { "Accuracy", "0" }
        };

        public double GetBaseCost() {
            double x = (double)DamageRating * 1.5;
            x = x * MultifeedChart[WeaponModifiers["MultiFeed"]];
            x = x * BurstValueChart[WeaponModifiers["BurstValue"]];
            x = x * AccuracyChart[WeaponModifiers["Accuracy"]];
            x = x * GetRangeCostMultiplier();
            x = x * GetOptionCostMult();
            return x;
        }
        public override double GetCost() {
            double x = GetBaseCost();
            foreach (ProjectileAmmo clip in Magazines) {
                x += clip.GetCost();
            }
            return x;
        }

        public override int GetRange() {
            double x = (double)Rangechart[DamageRating];
            x *= RangeModifier;
            return (int)x;
        }

        public override double GetStructure() {
            double x = DamageRating;
            foreach (ProjectileAmmo clip in (IsHandHeld) ? MultifeedClips() : Magazines) {
                x += clip.GetStructure();
            }
            return x;
        }
        public override double GetSpaces() {
            double spaces = GetBaseCost();
            foreach (ProjectileAmmo clip in (IsHandHeld) ? MultifeedClips() : Magazines) {
                spaces += clip.GetStructure();
            }
            spaces = Math.Round(Math.Max(1.0, spaces - (double)SpaceEfficiency));
            return spaces;
        }
    }
}
