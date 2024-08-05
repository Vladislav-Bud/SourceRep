using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Simple;

public class Simple : MonoBehaviour
{
    public Myenum ena;
    public int integer;
    public string str;

    public GameObject GameObject; 
    public Transform tr;
    public Color color;
    public Gradient gradient;
    public AnimationCurve curve;
    public Animation anim;

    public enum Myenum
    {
        one, two, three, four, five
    }

    public void Start()
    {
        Test test = new Test();
        test.setValue(9, "Bot", 9.9f, Myenum.five);
    }

    public struct Test
    {
        public int num;
        public string name;
        public float fl_num;
        public Myenum enam;

        public void setValue(int Num, string Name, float Fl_num, Myenum Enam)
        {
            num = Num;
            name = Name;
            fl_num = Fl_num;
            enam = Enam;

            Debug.Log("Number: " + num + "\n" +
                "Name: " + name + "\n" +
                "Float: " + fl_num + "\n" +
                "Enumerator: " + enam);
        }
    }
}
