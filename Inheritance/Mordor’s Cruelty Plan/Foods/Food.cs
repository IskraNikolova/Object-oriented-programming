namespace Mordor_s_Cruelty_Plan.Foods
{
    public abstract class Food
    {
        protected Food()
        {
            this.Points = Points;
        }

        public int Points { get; set; }
    }
}
