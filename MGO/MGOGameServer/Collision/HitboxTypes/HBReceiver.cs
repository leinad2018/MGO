using MGOGameServer.Entities;

namespace MGOGameServer.Collision.HitboxTypes
{
    /**
     * Hitbox type used for receiving hitbox effects
     * Each entity has one of these
     **/
    public class HBReceiver : Hitbox
    {
        public Entity owner { get; set; }

        public HBReceiver(Point origin, int radius, Entity owner) : base(origin, radius)
        {
            this.owner = owner;
        }
    }
}
