using MechBuilder.Src.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MechBuilder.Lookup;

namespace MechBuilder.Src.Systems {
    public class BeamWeapon : BaseRangedWeapon {
        public BeamWeapon() {
            BurstValueChart["inf"] = 5.0;
        }
        public override WeaponTypes GetWeaponType() {
            return WeaponTypes.Beam;
        }
        public Dictionary<string, double> AccuracyChart = new Dictionary<string, double>
        {
            { "-2", 0.6 },
            { "-1", 0.75 },
            { "0", 0.88 },
            { "1", 1 },
            { "2", 1.5 },
            { "3", 2 }
        };
        public Dictionary<int, int> Rangechart = new Dictionary<int, int>
        {
            { 1, 4 },
            { 2, 6 },
            { 3, 7 },
            { 4, 8 },
            { 5, 9 },
            { 6, 10 },
            { 7, 11 },
            { 8, 11 },
            { 9, 12 },
            { 10, 13 },
            { 11, 13 },
            { 12, 14 },
            { 13, 14 },
            { 14, 15 },
            { 15, 15 },
            { 16, 16 },
            { 17, 16 },
            { 18, 17 },
            { 19, 17 },
            { 20, 18 }
        };

        public Dictionary<object, double> WideAngleChart = new Dictionary<object, double>
        {
            {"none", 1.0 },
            { "hex", 2 },
            { "60", 3 },
            { "180", 5 },
            { "300", 7 },
            { "360", 9 }
        };

        public Dictionary<object, double> ShotsChart = new Dictionary<object, double>
        {
            { "1", 0.5 },
            { "2", 0.6 },
            { "3", 0.7 },
            { "5", 0.8 },
            { "10", 0.9 },
            { "15", 1.0 },
            { "inf", 1 }
        };
        public Dictionary<object, double> WarmUpChart = new Dictionary<object, double>
        {
            { "0", 1 },
            { "1", 0.9 },
            { "2", 0.7 },
            { "3", 0.6 }
        };

        public Dictionary<string, string> WeaponModifiers = new Dictionary<string, string>
        {
            { "WarmUp", "0"},
            { "Shots", "inf"},
            { "Wideangle", "none"},
            { "BurstValue", "none"},
            { "Accuracy", "1" }
        };
        public int Clips = 1;
        public override double GetCost() {
            double x = (double)DamageRating * 1.5;
            x = x * WarmUpChart[WeaponModifiers["WarmUp"]];
            x = x * BurstValueChart[WeaponModifiers["BurstValue"]];
            x = x * WideAngleChart[WeaponModifiers["WideAngle"]];
            x = x * ShotsChart[WeaponModifiers["Shots"]];
            x = x * AccuracyChart[WeaponModifiers["Accuracy"]];
            x = x * GetRangeCostMultiplier();
            x = x * GetOptionCostMult();
            if ((Options & WeaponOptions.ClipFed) > 0)
                x += Clips;
            return x;
        }

        public override int GetRange() {
            double x = (double)Rangechart[DamageRating];
            x *= RangeModifier;
            return (int)x;
        }

        public override double GetStructure() {
            return ((Options & WeaponOptions.Fragile) == WeaponOptions.Fragile) ? 1 : DamageRating;
        }
    }
}
