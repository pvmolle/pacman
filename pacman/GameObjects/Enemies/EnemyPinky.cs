namespace Pacman
{
    public class EnemyPinky : Enemy
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
                    return "../../../assets/pinky.png";
                }
            }
        }

        public EnemyPinky(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {
        }
    }
}