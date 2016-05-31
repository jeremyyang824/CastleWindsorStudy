using Castle.Core;

namespace Part06.SwitchingBetweenLifestyles
{
    //[Transient]
    public class AddingService
    {
        public int Total { get; private set; } = 0;

        public void AddAmmount(int ammount)
        {
            this.Total += ammount;
        }
    }
}
