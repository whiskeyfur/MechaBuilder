using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MechBuilder.Src.Base;

namespace MechBuilder {
    public class BaseMeleeWeapon : Src.Base.BaseWeapon {
        public override double GetCost() {
            throw new NotImplementedException();
        }

        public override int GetRange() {
            throw new NotImplementedException();
        }

        public override double GetStructure() {
            throw new NotImplementedException();
        }

        public override WeaponTypes GetWeaponType() {
            throw new NotImplementedException();
        }
    }
}