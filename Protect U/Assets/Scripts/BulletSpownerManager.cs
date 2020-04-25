using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpownerManager : MonoBehaviour
{
    public Spowner [] spownerArr;
    public GameObject normalBullet;
    public GameObject bulletPool;

    public static BulletSpownerManager instance;

    //[SerializeField] private Dictionary<string,GameObject> bulletPoolDic;
    [SerializeField] private DictionaryList<string,GameObject> bulletPoolDicList;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(this);
        }
        //bulletPoolDic = new Dictionary<string, GameObject>();
        bulletPoolDicList = new DictionaryList<string, GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (Spowner spw in spownerArr)
        {
            //spw.spownBullet(bullets [0]);
        }
    }

    public void putInBulletPool(GameObject bullet)
    {

        //bulletPoolDic.Add(bullet.name,bullet);
        bulletPoolDicList.Add(bullet.name,bullet);
        bullet.transform.parent = bulletPool.transform;
        bullet.SetActive(false);
    }

    public bool putOutBulletPool(string name, out GameObject bullet)
    {
        //bool hasGottenBullet = bulletPoolDic.TryGetValue(name, out bullet);
        bool hasGottenBullet = bulletPoolDicList.TryGetValue(name, out bullet);
        if (hasGottenBullet)
        {
            bullet.SetActive(true);
            bullet.transform.parent = null;
        }
        return hasGottenBullet;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpownBullet(int indexOfSpowner, GameObject bullet)
    {
        GameObject go;
        if (putOutBulletPool(bullet.name,out go))
        {
            spownerArr [indexOfSpowner].getExistedBullet(go);
        }
        else
            spownerArr[indexOfSpowner].spownBullet(bullet);
    }

}
