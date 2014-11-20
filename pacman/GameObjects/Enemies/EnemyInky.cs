namespace Pacman
{
    public class EnemyInky : Enemy
    {
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
                    return "../../../assets/inky.png";
                }
            }
        }

        public EnemyInky(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {
        }
    }
}