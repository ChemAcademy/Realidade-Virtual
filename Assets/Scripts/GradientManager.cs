using UnityEngine;

public class GradientManager : MonoBehaviour
{
  public GameObject BrainObject;

  string obj_name;

  int obj_number;
  float temperature1;
  float temperature2;

  float T_s;
  float T_0;
  bool running;

  public Material oil_material;

  void Start()
  {
    obj_name = this.name;
    obj_number = int.Parse(obj_name.Substring(obj_name.Length - 2));
    obj_number = Mathf.Abs(obj_number);

    oil_material = this.GetComponent<Renderer>().material;
    T_s = BrainObject.GetComponent<GeneralTemperature>().T_s;
    T_0 = BrainObject.GetComponent<GeneralTemperature>().T_0;

    running = BrainObject.GetComponent<GeneralTemperature>().running;
  }

  float GetR(float temp)
  {
    float newR = 1 - 0.5f * (temp - T_0) / (T_s - T_0);

    return newR;
  }

  // Update is called once per frame
  void FixedUpdate()
  {

    running = BrainObject.GetComponent<GeneralTemperature>().running;

    if (!running)
    {
      return;
    }

    if (obj_number == 98)
    {
      temperature1 = T_0;
      temperature2 = BrainObject.GetComponent<GeneralTemperature>().temperatures[0];
    }

    else if (obj_number == 99)
    {
      temperature1 = BrainObject.GetComponent<GeneralTemperature>().temperatures[16];
      temperature2 = BrainObject.GetComponent<GeneralTemperature>().temperatures[16];
    }

    else
    {
      temperature1 = BrainObject.GetComponent<GeneralTemperature>().temperatures[obj_number - 1];
      temperature2 = BrainObject.GetComponent<GeneralTemperature>().temperatures[obj_number];
    }

    oil_material.SetColor("_TopColor", new Color(1, GetR(temperature1), 0, 1));
    oil_material.SetColor("_BottomColor", new Color(1, GetR(temperature2), 0, 1));
  }
}
