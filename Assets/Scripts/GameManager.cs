using UnityEngine;
public class GameManager : MonoBehaviour
{
    public Slime Slime1 = new(7);
    public Slime Slime2 = new(9);
    void Start()
    {
        print("Bienvenido al mundo de los slimes");
        print("Oh... Se han creado 2 slimes con vidas de 7 y 9 respectivamente");
        print("Presiona Space para poder fusionarlos");
    }
    void Update()
    {
        AddSlimes();
    }
    public void AddSlimes()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Slime Slime3 = Slime1 + Slime2;

            print("El nuevo slime tiene de vida " + Slime3.life);
        }
    }
}
