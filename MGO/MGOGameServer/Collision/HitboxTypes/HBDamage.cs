using MGOGameServer.Entities;

namespace MGOGameServer.Collision.HitboxTypes
{
    public class HBDamage : HBEffect
    {
        private int damage;

        public HBDamage(Point origin, int radius, int damage) : base(origin, radius)
        {
            this.damage = damage;
        }

        override
        public void effect(Entity other)
        {
            other.doDamage(damage);
        }
    }
}
