using System;
using System.Collections.Generic;
using MechBuilder.Base;
using static MechBuilder.Lookup;

namespace MechBuilder.Src.Base
{
    /// <summary>
    /// This is an abstract class for building a weapon system.
    /// </summary>
    public abstract class BaseWeapon : BaseSystem {
        /// <summary>
        /// These are the weapon types.
        /// </summary>
        public enum WeaponTypes : byte
        {
            Beam,
            EMW,
            Missile,
            Projectile,
            Melee
        }
        /// <summary>
        /// This is here for reference.
        /// </summary>
        public enum WeaponModifierTypes : int
        {
            Accuracy,
            Warmup,
            WideAngle,
            BurstValue,
            Shots,
            SmartValue,
            SmartSkill,
            BlastRadius,
            TurnsInUse,
            AttackFactor,
            MultiFeed
        }
        /// <summary>
        /// These are the weapon options flags for use with bitwise math.
        /// </summary>
        [FlagsAttribute]
        public enum WeaponOptions : int
        {
            Normal = 1,
            AntiPersonnel = 2,
            AntiPersonnelVariable = 3,
            AntiMissile = 4,
            AntiMissileVariable = 5,
            AntiMissileAntiPersonnel = 6,
            AllPurpose = 7,
            LongRange = 8,
            Disruptor = 16,
            ArmorPiercing = 32,
            HyperVelocity = 64,
            MegaBeam = 128,
            HydroBeam = 256,
            Foam = 512,
            Smoke = 1024,
            Flare = 2048,
            Scatter = 4096,
            ScatterSmoke = 5120,
            Fuse = 8192,
            ClipFed = 16384,
            Thrown = 32768,
            Returning = 65536,
            Quick = 131072,
            Handy = 262144,
            Entangle = 524288,
            Clumsy = 1048576,
            ShockOnly = 2097152,
            ShockAdded = 2097153,
            Rechargable = 4194304,
            SpecialEffect = 8388608,
            BeamShield = 16777216,
            BeamShieldVariable = 16777217,
            HyperEMW = 33554432,
            Fragile = 67108864,
            Nuclear = 134217728
        }
        public WeaponOptions BeamOptions = WeaponOptions.Normal | WeaponOptions.AntiMissile | WeaponOptions.AntiPersonnel | WeaponOptions.ClipFed | WeaponOptions.Disruptor | WeaponOptions.LongRange | WeaponOptions.MegaBeam | WeaponOptions.HydroBeam | WeaponOptions.SpecialEffect;
        public WeaponOptions ProjectileOptions = WeaponOptions.Normal | WeaponOptions.AntiMissile | WeaponOptions.AntiPersonnel | WeaponOptions.HyperVelocity | WeaponOptions.LongRange | WeaponOptions.SpecialEffect;
        public WeaponOptions MissileOptions = WeaponOptions.Normal | WeaponOptions.AntiMissile | WeaponOptions.HyperVelocity | WeaponOptions.LongRange | WeaponOptions.Flare | WeaponOptions.Foam | WeaponOptions.Fuse | WeaponOptions.Scatter | WeaponOptions.Smoke | WeaponOptions.Nuclear | WeaponOptions.SpecialEffect;
        public WeaponOptions EMWOptions = WeaponOptions.Quick | WeaponOptions.Thrown | WeaponOptions.Normal | WeaponOptions.BeamShield | WeaponOptions.HyperEMW | WeaponOptions.Rechargable | WeaponOptions.SpecialEffect;
        public WeaponOptions MeleeOptions = WeaponOptions.Quick | WeaponOptions.Thrown | WeaponOptions.Normal | WeaponOptions.Returning | WeaponOptions.ShockOnly | WeaponOptions.Handy | WeaponOptions.Entangle | WeaponOptions.Disruptor | WeaponOptions.Clumsy | WeaponOptions.ArmorPiercing | WeaponOptions.SpecialEffect;

        /// <summary>
        /// This is how much damage the weapon will do. 
        /// </summary>
        public int DamageRating { get; set; }
        /// <summary>
        /// This returns what type of weapon we are building.
        /// </summary>
        public abstract WeaponTypes GetWeaponType();
        /// <summary>
        /// This will determine how much the weapon costs.
        /// </summary>
        /// <returns></returns>
        public abstract double GetCost();
        /// <summary>
        /// This will store the (bitwise) options for the weaponsystem instance.
        /// </summary>
        public WeaponOptions Options { get; set; }
        
        public double RangeModifier = 1.00;

        /// <summary>
        /// This is how far the weapon can reach.
        /// </summary>
        /// <returns></returns>
        public abstract int GetRange();
        /// <summary>
        /// This is how sturdy the weapon is.
        /// </summary>
        /// <returns></returns>
        public abstract double GetStructure();
        /// <summary>
        /// This is how much the weapon will weigh.
        /// </summary>
        /// <returns></returns>
        public virtual double GetWeight()
        {
            return GetStructure() / 2.0;
        }
        /// <summary>
        /// This returns the cost multiplier for the 
        /// </summary>
        /// <returns></returns>
        public virtual double GetRangeCostMultiplier()
        {
            double x;
            x = RangeModifier / 2.0 + 0.5;
            return x;
        }
        /// <summary>
        /// This returns the cost of the weapon system's 'flaggable' options.
        /// </summary>
        /// <returns></returns>
        public double GetOptionCostMult()
        {
            double x = 1.0;
            switch (GetWeaponType())
            {
                case (WeaponTypes.Beam):
                    Options &= BeamOptions;
                    break;
                case (WeaponTypes.Missile):
                    Options &= MissileOptions;
                    break;
                case (WeaponTypes.Projectile):
                    Options &= ProjectileOptions;
                    break;
                case (WeaponTypes.EMW):
                    Options &= EMWOptions;
                    break;
                case (WeaponTypes.Melee):
                    Options &= MeleeOptions;
                    break;
                default:
                    throw new System.ArgumentException("GetWeaponType() failed to have a valid weapon type.");
            }
            switch (Options & (WeaponOptions.AllPurpose))
            {
                case (WeaponOptions.AllPurpose):
                    x *= 2.6;
                    break;
                case (WeaponOptions.AntiMissileVariable):
                    if(GetWeaponType() == WeaponTypes.Projectile)
                    {
                        x *= 1.4;
                        break;
                    }
                    goto case (WeaponOptions.AntiMissileAntiPersonnel);
                case (WeaponOptions.AntiMissileAntiPersonnel):
                    if (GetWeaponType() == WeaponTypes.Projectile)
                    {
                        x *= 1.6;
                        break;
                    }
                    goto case (WeaponOptions.AntiPersonnelVariable);
                case (WeaponOptions.AntiPersonnelVariable):
                {
                    x *= 1.8;
                    break;
                }
                case (WeaponOptions.AntiMissile):
                    if(GetWeaponType() == WeaponTypes.Projectile)
                    {
                        x *= 0.5;
                        break;
                    }
                    x *= 1.0;
                    break;
                case (WeaponOptions.AntiPersonnel):
                    {
                        x *= 1.0;
                        break;
                    }
            }
            if ((Options & WeaponOptions.ArmorPiercing) > 0) x *= 2.0;
            if ((Options & WeaponOptions.Disruptor) > 0) x *= 2.0;
            if ((Options & WeaponOptions.Quick) > 0) x *= 2.0;
            if ((Options & WeaponOptions.Handy) > 0) x *= 1.5;
            if ((Options & WeaponOptions.MegaBeam) > 0) x *= 10.0;
            if ((Options & WeaponOptions.Rechargable) > 0) x *= 1.1;
            if ((Options & WeaponOptions.Thrown) > 0) x *= 1.2;
            if ((Options & WeaponOptions.LongRange) > 0) x *= 1.33;
            if ((Options & WeaponOptions.HydroBeam) > 0) x *= 0.2;
            if ((Options & WeaponOptions.Fragile) > 0) x *= 1.0;
            if ((Options & WeaponOptions.ShockAdded) == WeaponOptions.ShockAdded) { x *= 3.0; }
            else if ((Options & WeaponOptions.ShockOnly) > 0) { x *= 2.0; }
            if ((Options & WeaponOptions.Returning) > 0) x *= 1.5;
            if ((Options & WeaponOptions.Entangle) > 0) x *= 1.25;
            if ((Options & WeaponOptions.Clumsy) > 0) x *= 0.5;
            if ((Options & WeaponOptions.ClipFed) > 0) x *= 0.9;
            if ((Options & WeaponOptions.Foam) > 0) x *= 1.33;
            if ((Options & WeaponOptions.Nuclear) > 0) x *= 1000.0;
            if ((Options & WeaponOptions.Flare) > 0) x *= 1.0;
            if ((Options & WeaponOptions.ScatterSmoke) == WeaponOptions.ScatterSmoke) { x *= 1.0; }
            else if ((Options & WeaponOptions.Smoke) > 0) { x *= 0.5; }
            else if ((Options & WeaponOptions.Scatter) > 0) { x *= 0.5; }
            if ((Options & WeaponOptions.HyperVelocity) > 0) x *= 1.25;
            if ((Options & WeaponOptions.Fuse) > 0) x *= 1.1;
            if ((Options & WeaponOptions.HyperEMW) > 0) x *= 7.5;
            if ((Options & WeaponOptions.BeamShieldVariable) == WeaponOptions.BeamShieldVariable) { x *= 2.0; }
            else if ((Options & WeaponOptions.BeamShield) > 0) { x *= 1.5; }
            if ((Options & WeaponOptions.SpecialEffect) > 0) x *= 1.33;
            return x;
        }
        /// <summary>
        /// This gives the cost of various burst value modifiers.
        /// </summary>
        public Dictionary<string, double> BurstValueChart = new Dictionary<string, double>
        {
            {"None", 1.0 },
            { "2", 1.5 },
            { "3", 2 },
            { "4", 2.5 },
            { "5", 3 },
            { "6", 3.5 },
            { "7", 4 },
            { "8", 4.5 }
        };
        /// <summary>
        /// This is how much space the weapon takes up.
        /// </summary>
        /// <returns></returns>
        public virtual double GetSpaces()
        {
            double spaces = GetCost();
            spaces = Math.Round(Math.Max(1.0, spaces - (double)SpaceEfficiency));
            return spaces;
        }
        /// <summary>
        /// This is how much space we're cutting off of a weapon to make it fit.
        /// </summary>
        public double SpaceEfficiency { get; set; }

    }
}
