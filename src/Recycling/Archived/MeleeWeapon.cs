using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    public class MeleeWeapon : BaseMeleeWeapon {
        public Dictionary<string, string> WeaponModifiers = new Dictionary<string, string>
        {
            { "Accuracy", "0" }
        };
        
        public override double GetCost()
        {
            double x = (double)DamageRating / 2;
            x = x * AccuracyChart[WeaponModifiers["Accuracy"]];
            x = x * GetOptionCostMult();
            return x;
        }
        public Dictionary<string, double> AccuracyChart = new Dictionary<string, double>
        {
            { "-2", 0.6 },
            { "-1", 0.8 },
            { "0", 1 },
            { "1", 1.5 },
            { "2", 2 }
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
            x = (double)DamageRating;
            return x;
        }

        public override WeaponTypes GetWeaponType()
        {
            return WeaponTypes.Melee;
        }

        public override double GetWeight()
        {
            return base.GetWeight();
        }
    }
}