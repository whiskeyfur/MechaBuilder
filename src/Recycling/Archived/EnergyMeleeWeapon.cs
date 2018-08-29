using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MechBuilder.Src.Base;

namespace MechBuilder {
    public class EnergyMeleeWeapon : BaseMeleeWeapon
    {
        public Dictionary<string, string> WeaponModifiers = new Dictionary<string, string>
        {
            { "TurnsInUse", "inf"},
            { "AttackFactor", "none"},
            { "Accuracy", "1" }
        };
        public double AttackFactorCalc(string y)
        {
            double x;
            int z = 0;
            int.TryParse(y, out z);
            x = (z > 0) ? ((double)z * 0.5 + 1) : 1;
            return x;
        }
        public double AttackFactorCalc(int y)
        {
            double x;
            x = (y > 0) ? ((double)y * 0.5 + 1) : 1;
            return x;
        }
        public override double GetCost()
        {
            double x = (double)DamageRating;
            x = x * AccuracyChart[WeaponModifiers["Accuracy"]];
            x = x * TurnsInUseChart[WeaponModifiers["TurnsInUse"]];
            x = x * AttackFactorCalc(WeaponModifiers["AttackFactor"]);
            x = x * GetOptionCostMult();
            return x;
        }
        public Dictionary<string, double> TurnsInUseChart = new Dictionary<string, double>
        {
            { "1", 0.3 },
            { "2", 0.4 },
            { "3", 0.5 },
            { "4", 0.6 },
            { "5", 0.7 },
            { "7", 0.8 },
            { "10", 0.9 },
            { "inf", 1 }
        };
        public Dictionary<string, double> AccuracyChart = new Dictionary<string, double>
        {
            { "-2", 0.6 },
            { "-1", 0.8 },
            { "0", 0.9 },
            { "1", 1 },
            { "2", 1.5 },
            { "3", 2 }
        };
        public override int GetRange()
        {
            return 0;
        }

        public override double GetSpaces()
        {
            return base.GetSpaces();
        }

        public override double GetStructure()
        {
            double x;
            x = (double)DamageRating / 5.0;
            x = Math.Max(x, 1);
            return x;
        }

        public override WeaponTypes GetWeaponType()
        {
            return WeaponTypes.EMW;
        }

        public override double GetWeight()
        {
            return base.GetWeight();
        }
    }
}