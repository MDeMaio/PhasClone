using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private float LightRange;

    [SerializeField] private float LightIntensity;
    [SerializeField] private Light Spotlight;
    [SerializeField] private AudioSource click;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.F)){
           Spotlight.enabled = !Spotlight.enabled;
           click.Play();
        }
    }
}
