using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public int rus = 0;
    public int heroism = 0;
    public List<Variant> variants;

    public TMP_Text discription;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetVariant()
    {
        var variant = variants.Where(v => v.rusPoints.Contains(rus) && v.heroismPoints.Contains(heroism)).FirstOrDefault();
        //На случай если косячно заполнены данные, чтобы дальше не поломалось
        if (variant == null)
            variant = variants.Where(v => v.id == 7).FirstOrDefault();

        discription.text = variant.text;
        image.sprite = variant.sprite;

    }
}
