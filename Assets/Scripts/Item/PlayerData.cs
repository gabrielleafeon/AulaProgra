public struct PlayerData
{
    public int health;
    public int damage;

    public PlayerData(int health, int damage)
    {
        this.health = health;
        this.damage = damage;
    }

    public void IncreaseDmg()
    {
        damage += 1;
    }

}
