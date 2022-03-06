using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
   
   public Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = "L I V E S  L E F T  :  " + PlayerStats.Lives.ToString();
    }
}
