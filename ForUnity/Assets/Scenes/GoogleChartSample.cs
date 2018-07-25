using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FlugleCharts;

public class GoogleChartSample : MonoBehaviour
{
    public RawImage image;

    // Use this for initialization
    IEnumerator Start()
    {
        var s1 = new Series();

        s1.Add("Hello", 60);
        s1.Add("World", 40);

        var pie = ChartBuilder.Pie(PieType.ThreeDimensional)
                              .Size(250, 100)
                              .AddSeries(s1);


        var www = new WWW(pie.GetUrl());
        yield return www;
        image.texture = www.textureNonReadable;
        image.SetNativeSize();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
