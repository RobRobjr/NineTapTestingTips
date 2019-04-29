using System;

namespace NineTapTestingTips
{
    public class Game
    {
        private short? _game1;

        public short? Game1
        {
            get { return _game1; }
            set
            {
                if (IsValidScore(value))
                {
                    _game1 = value;
                }
                else
                {
                    throw new ArgumentException("Score 0 - 300");
                }
            }
        }

        private bool IsValidScore(short? score)
        {
            if (score.HasValue && score.Value >= 0 && score.Value <= 300)
            {
                
                   return true;
                
            }
            return false;
        }

        public short? Game2 { get; set; }

        public short? Game3 { get; set; }

        public short? Game4 { get; set; }

        public short? TotalScore
        {
            get { return (short?)( Game1 + Game2 + Game3 + Game4 ); }
        }
    }
}
