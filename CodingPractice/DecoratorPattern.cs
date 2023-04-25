using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public class JetFighter
    {
        public List<Weapon> weapons = new List<Weapon>();

        public void LoadWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
        }
    }

    public interface Weapon
    {
        public void Fire();
    }


    public class Missile : Weapon
    {
        public void Fire()
        {
            Console.WriteLine("Missile released!");
        }
    }

    public abstract class WeaponModifier : Weapon
    {
        public Weapon m_weaponToModify;

        public void Fire()
        {
            m_weaponToModify.Fire();
            Modify();
        }

        public abstract void Modify();
    }

    public class HeatSeeking : WeaponModifier
    {
        public HeatSeeking(Weapon _weapon)
        {
            m_weaponToModify = _weapon;
        }

        public override void Modify()
        {
            Console.WriteLine("Searching for hot objects..");
        }
    }

    public class Hypersonic : WeaponModifier
    {
        public Hypersonic(Weapon _weapon)
        {
            m_weaponToModify = _weapon;
        }

        public override void Modify()
        {
            Console.WriteLine("Igniting Hypersonic Engine!");
        }
    }


}
