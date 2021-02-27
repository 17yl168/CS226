using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fade : MonoBehaviour
{

    public Texture image;
    static float alpha = 0f;
    public static bool danchu = false;
    public static bool danru = false;
    public float speed;
    public static string changjing;
    private void OnGUI()
    {
   
        if (danchu)
        {
            alpha += speed * Time.deltaTime;
            if (alpha >= 1)
            {
                SceneManager.LoadScene(changjing);
                danchu = false;
                danru = true;
            }
            
        }
        if (danru)
        {
            alpha -= speed * Time.deltaTime;
            if (alpha <= 0)
            {
                danru = false;
            }
        }
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), image);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            fade.danchu = true;
            fade.changjing = "night";
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            fade.danchu = true;
            fade.changjing = "day";
        }
    }
}
