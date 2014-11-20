namespace Pacman
{
    public class EnemyBlinky : Enemy
    {
        public static IStrategy defaultStrategy;

        protected override string Resource
        {
            get
            {
                if (IsFleeing)
                {
                    return base.Resource;
                }
                else
                {
                    return "../../../assets/blinky.png";
                }
            }
        }

        public EnemyBlinky(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {
        }
    }
}