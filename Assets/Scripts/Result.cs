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
    public List<Variant> variantsKnow;

    public TMP_Text discription;
    public Image image;
    public Coordinate coordinate;
    public Saves saves;
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
        coordinate.coordinateDot.SetActive(true);
        coordinate.SetCoordinate(rus, heroism);
        coordinate.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
        saves.OpenResult(variant.id);
    }
    public void SetVariant(int variantId)
    {
        var variant = variants.Where(v => v.id == variantId).FirstOrDefault();
        //На случай если косячно заполнены данные, чтобы дальше не поломалось
        if (variant == null)
            variant = variants.Where(v => v.id == 7).FirstOrDefault();

        discription.text = variant.text;
        image.sprite = variant.sprite;
        coordinate.coordinateDot.SetActive(false);
        coordinate.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
    }

    public void SetVariantKnow()
    {
        var variantKnow = variantsKnow.Where(v => v.rusPoints.Contains(rus)).FirstOrDefault();
        discription.text = variantKnow.text;
        coordinate.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
    }
}
