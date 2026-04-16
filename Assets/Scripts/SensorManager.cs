using TMPro;
using UnityEngine;

public class SensorManager : MonoBehaviour
{
    public GameObject lodo;
    public TextMeshProUGUI sensorHumedadText;
    
    public void SetupSensors(SensorInfo sensorInfo)
    {
        sensorHumedadText.text = sensorInfo.humedad.ToString("0.00");

        if (sensorInfo.humedad > 0.5f)
        {
            lodo.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            lodo.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        Debug.Log("Sensors: " + sensorInfo.sensores.Count);
    }
}
