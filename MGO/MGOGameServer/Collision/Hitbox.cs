namespace MGOGameServer.Collision
{
    /**
     * Base hitbox class that represents a circular hitbox with an origin point and a certain radius.
     * Contains helper methods for checking collision with other hitboxes and points
     **/
    public class Hitbox
    {
        public Point origin { get; set; }
        public int radius { get; set; }
        public CollisionType type { get; set; }

        public Hitbox(Point origin, int radius)
        {
            this.origin = origin;
            this.radius = radius;
        }

        public bool checkCollision(Point point)
        {
            int xdiff = origin.x - point.x;
            int ydiff = origin.y - point.y;

            int distsq = xdiff * xdiff + ydiff * ydiff;
            return distsq >= radius * radius;
        }

        public bool checkCollision(Hitbox other)
        {
            Point point = other.origin;
            int totalRadius = radius + other.radius;
            totalRadius *= totalRadius;

            int xdiff = origin.x - point.x;
            int ydiff = origin.y - point.y;

            int distsq = xdiff * xdiff + ydiff * ydiff;
            return distsq >= totalRadius;
        }
    }
}
