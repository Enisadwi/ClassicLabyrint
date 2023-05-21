using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrientationTest : MonoBehaviour
{
    [SerializeField] TMP_Text systemInfoText;
    
    void Start()
    {
        systemInfoText.text = "Sensors:";
        if(SystemInfo.supportsAccelerometer)
        systemInfoText.text += "Accelerometer";
        if(SystemInfo.supportsGyroscope)
        {
        systemInfoText.text += "Gyroscope";
        Input.gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("gravity"+Input.gyro.gravity);
         Debug.Log("acceleration"+Input.acceleration);
         Debug.Log("userAcceleration"+Input.gyro.userAcceleration);
         Debug.Log("rotationRateUnbiased"+Input.gyro.rotationRateUnbiased);
         Debug.Log("rotationRate"+Input.gyro.rotationRate);
         Debug.Log("attitude"+Input.gyro.attitude);
    }
}
