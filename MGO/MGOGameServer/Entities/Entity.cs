using MGOGameServer.Collision.HitboxTypes;

namespace MGOGameServer.Entities
{
    public abstract class Entity
    {
        protected HBReceiver receiver;

        public abstract void doDamage(int damage);
    }
}
