namespace Override
{
    public abstract class Puppet
    {
        public string Name { get; }
        public int Cost { get; }
        public int MoneyPerSec { get; }

        public Puppet(string name, int cost, int moneyPerSec)
        {
            Name = name;
            Cost = cost;
            MoneyPerSec = moneyPerSec;
        }
    }
}
