using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int life = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            float probability = Random.Range(1f, 10f);
            Debug.Log("Probabilidad generada: " + System.Math.Round(probability, 2));

            if (probability <= 5)
            {
                GetDamage(20);
            }
            else if (probability <= 7)
            {
                GetDamage(Random.Range(70, 90), false);
            }
            else
            {
                GetDamage(Random.Range(70, 90), true);
            }
        }
    }
    public void GetDamage(int damageBasic)
    {
        life = Mathf.Max(life - damageBasic, 0);
        Debug.Log("Daño básico recibido: -" + damageBasic + " puntos!!!. Vida actual: " + life);
        Death();
    }

    public void GetDamage(int damageCritical, bool knockback)
    {
        int totalDamage = damageCritical;

        if (knockback)
        {
            totalDamage += 20;
            Debug.Log("Daño crítico con knockback: -" + totalDamage + " puntos!!!.");
        }
        else
        {
            Debug.Log("Daño crítico sin knockback: -" + totalDamage + " puntos!!!.");
        }

        life = Mathf.Max(life - totalDamage, 0);
        Debug.Log("Vida actual: " + life);

        Death();
    }
    private void Death()
    {
        if (life <= 0)
        {
            Debug.Log("El Player ha muerto.");
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        Debug.Log("El Player ha sido destruido.");
    }
}