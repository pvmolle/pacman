namespace Pacman
{
    public class EnemyClyde : Enemy
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
                    return "../../../assets/clyde.png";
                }
            }
        }

        public EnemyClyde(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {
        }
    }
}