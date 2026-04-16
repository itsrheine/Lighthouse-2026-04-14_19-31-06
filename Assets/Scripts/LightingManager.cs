using UnityEngine;

public class LightingManager : MonoBehaviour
{
    public Light directionalLight;

    public void SetMorning()
    {
        directionalLight.color = new Color(0.8f, 0.85f, 1f);
        directionalLight.intensity = 0.5f;
        directionalLight.transform.rotation = Quaternion.Euler(20f, -30f, 0f);
        RenderSettings.fogColor = new Color(0.7f, 0.8f, 0.9f);
    }

    public void SetNoon()
    {
        directionalLight.color = Color.white;
        directionalLight.intensity = 1f;
        directionalLight.transform.rotation = Quaternion.Euler(60f, 0f, 0f);
        RenderSettings.fogColor = new Color(0.8f, 0.85f, 0.9f);
    }

    public void SetEvening()
    {
        directionalLight.color = new Color(1f, 0.6f, 0.4f);
        directionalLight.intensity = 0.6f;
        directionalLight.transform.rotation = Quaternion.Euler(10f, 30f, 0f);
        RenderSettings.fogColor = new Color(0.9f, 0.5f, 0.4f);
    }
}