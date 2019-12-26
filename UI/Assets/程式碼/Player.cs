using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hp = 100;
    public Slider hpSlider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "陷阱")
        {
            int d = other.GetComponent<Trap>().damage;
            hp -= d;
            hpSlider.value = hp;
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "陷阱")
        {
            int d = other.GetComponent<Trap>().damage;
            hp -= d;
            hpSlider.value = hp;
        }
    }

}
