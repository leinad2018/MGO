using MGOGameServer.Entities;

namespace MGOGameServer.Collision.HitboxTypes
{
    public abstract class HBEffect : Hitbox
    {
        public HBEffect(Point origin, int radius) : base(origin, radius) { }

        public abstract void effect(Entity other);
    }
}
