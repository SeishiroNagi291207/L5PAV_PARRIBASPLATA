using UnityEngine;

public class Slime
{
    public int life = 10;

    public Slime(int _life)
    {
        life = _life;
    }

    public static Slime operator +(Slime Slime1, Slime Slime2)
    {
        return new Slime(Slime1.life + Slime2.life);
    }
}