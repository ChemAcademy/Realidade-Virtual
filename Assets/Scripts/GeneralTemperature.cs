using UnityEngine;

public class GeneralTemperature : MonoBehaviour
{
  // Start is called before the first frame update
  public float cur_time;
  public float[] temperatures;

  public float T_s = 800;
  public float T_0 = 200;
  public float k = 2;

  public bool running = false;
  void Start()
  {
    cur_time = 0;
    temperatures = new float[32];
  }

  float[] UpdateTemperatures(float[] temp_array)
  {
    float[] new_temps = new float[32];

    for (int i = 0; i < 32; i++)
    {
      if (i == 0)
      {
        new_temps[i] = T_0 + (T_s - T_0) * cur_time / (k + cur_time);
        continue;
      }

      new_temps[i] = T_0 + (new_temps[i - 1] - T_0) * cur_time / (k + cur_time);
    }

    return new_temps;
  }

  void FixedUpdate()
  {
    if (running)
    {
      cur_time += Time.deltaTime;
      temperatures = UpdateTemperatures(temperatures);
    }

  }

}
