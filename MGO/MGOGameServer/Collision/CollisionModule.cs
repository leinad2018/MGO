using MGOGameServer.Collision.HitboxTypes;
using MGOGameServer.Common;
using System.Collections.Generic;

namespace MGOGameServer.Collision
{
    /**
     * Simple first version of collision module that does the n^2 operation for checking collision
     **/
    public class CollisionModule : ServerModule
    {
        private List<HBReceiver> receivers;
        private List<HBEffect> effects;

        public void run()
        {
            foreach(HBReceiver receiver in receivers)
            {
                foreach(HBEffect effect in effects)
                {
                    bool collides;
                    switch (effect.type)
                    {
                        case CollisionType.CenterToCenter:
                            collides = effect.checkCollision(receiver.origin);
                            break;
                        case CollisionType.EdgeToEdge:
                            collides = effect.checkCollision(receiver);
                            break;
                        default:
                            collides = false;
                            break;
                    }

                    if (collides)
                    {
                        effect.effect(receiver.owner);
                    }
                }
            }
        }
    }
}
