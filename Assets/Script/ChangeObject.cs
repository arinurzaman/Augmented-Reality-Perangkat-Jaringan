using UnityEngine;
using System.Collections;

public class ChangeObject : MonoBehaviour
{
    public GameObject objek1, objek2, objek3, objek4, objek5, objek6, objek7, objek8, objek9, objek10, objek11, objek12;
    public GameObject[] objek3D = new GameObject[12];
    public int no = 1;

    public void Start()
    {
        objek3D[0] = objek1;
        objek3D[1] = objek2;
        objek3D[2] = objek3;
        objek3D[3] = objek4;
        objek3D[4] = objek5;
        objek3D[5] = objek6;
        objek3D[6] = objek7;
        objek3D[7] = objek8;
        objek3D[8] = objek9;
        objek3D[9] = objek10;
        objek3D[10] = objek11;
        objek3D[11] = objek12;
    }

    public void nextObject()
    {
        if (no < 12)
        {
            no++;
        }
    }

    public void prevObject()
    {
        if (no > 1)
        {
            no--;
        }
    }

    public void Update()
    {
        if (no == 1)
        {
            objek1.SetActive(true);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }
        if (no == 2)
        {
            objek1.SetActive(false);
            objek2.SetActive(true);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);


        }
        if (no == 3)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(true);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }
        if (no == 4)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(true);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }
        if (no == 5)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(true);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }

        if (no == 6)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(true);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }
        if (no == 7)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(true);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }
        if (no == 8)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(true);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }
        if (no == 9)
        {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(true);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(false);
        }

        if (no == 10)
         {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(true);
            objek11.SetActive(false);
            objek12.SetActive(false);

        }
         if (no == 11)
         {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(true);
            objek12.SetActive(false);

        }
        if(no == 12)
         {
            objek1.SetActive(false);
            objek2.SetActive(false);
            objek3.SetActive(false);
            objek4.SetActive(false);
            objek5.SetActive(false);
            objek6.SetActive(false);
            objek7.SetActive(false);
            objek8.SetActive(false);
            objek9.SetActive(false);
            objek10.SetActive(false);
            objek11.SetActive(false);
            objek12.SetActive(true);

        }

    }
    }