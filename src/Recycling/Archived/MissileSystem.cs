using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MechBuilder.Src.Base;

namespace MechBuilder {
    public class MissileSystem : BaseRangedWeapon {
        public override int GetRange()
        {
            double x = (double)Rangechart[DamageRating];
            x *= RangeModifier;
            return (int)x;
        }

        public override double GetStructure()
        {
            return Math.Max(Math.Round((double)(Shots * DamageRating) / 15),1);
        }

        public override WeaponTypes GetWeaponType()
        {
            return WeaponTypes.Missile;
        }
        public Dictionary<string, double> AccuracyChart = new Dictionary<string, double>
        {
            { "-2", 0.6 },
            { "-1", 0.8 },
            { "0", 1.0 },
            { "1", 1.3 },
            { "2", 1.6 },
            { "3", 2 }
        };
        public Dictionary<string, double> BlastRadiusChart = new Dictionary<string, double>
        {
            { "1", 3 },
            { "2", 4 },
            { "3", 5 },
            { "4", 6 },
            { "5", 7 },
            { "6", 7.5 },
            { "7", 8 },
            { "8", 8.5 },
            { "9", 9 },
            { "10", 10 },
            { "20", 20 }
        };
        public Dictionary<string, double> SmartSkillChart = new Dictionary<string, double>
        {
            { "6", 1 },
            { "9", 1.3 },
            { "12", 1.6 },
            { "15", 1.9 },
            { "18", 2.2 },
            { "20", 2.5 }
        };
        public double SmartTrackingCost(string y)
        {
            double x;
            int z = 0;
            int.TryParse(y, out z);
            x = (z > 0 )? ((double)z * 0.5 + 2):1;
            return x;
        }
        public Dictionary<int, int> Rangechart = new Dictionary<int, int>
        {
            { 1, 4 },
            { 2, 5 },
            { 3, 6 },
            { 4, 7 },
            { 5, 8 },
            { 6, 9 },
            { 7, 9 },
            { 8, 10 },
            { 9, 11 },
            { 10, 11 },
            { 11, 12 },
            { 12, 12 },
            { 13, 13 },
            { 14, 13 },
            { 15, 14 },
            { 16, 14 },
            { 17, 14 },
            { 18, 15 },
            { 19, 15 },
            { 20, 16 }
        };
        public Dictionary<string, string> WeaponModifiers = new Dictionary<string, string>
        {
            { "Accuracy", "0" },
            { "SmartSkill", "6" },
            { "SmartTracking", "0" },
            { "Blast Radius", "None"}
        };

        public int Shots = 10;
        public override double GetCost()
        {
            double x = (double)DamageRating * 0.1;
            x = x * AccuracyChart[WeaponModifiers["Accuracy"]];
            x = x * BlastRadiusChart[WeaponModifiers["Blast Radius"]];
            x = x * SmartTrackingCost(WeaponModifiers["SmartTracking"]);
            x = x * SmartSkillChart[WeaponModifiers["SmartSkill"]];
            x = x * GetRangeCostMultiplier();
            x = x * GetOptionCostMult();
            x = x * Shots;
            return x;
        }
    }
}