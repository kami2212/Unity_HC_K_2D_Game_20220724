using UnityEngine;
using UnityEngine.Pool;
namespace Su
{
    /// <summary>
    /// 物件池基底
    /// </summary>
    public class ObjectpoolBase : MonoBehaviour
    {
        #region 資料
        [SerializeField,Header("物件")]
        private GameObject goTarget;
        [SerializeField, Header("物件池最大數量"), Range(0, 100)]
        private int countMax = 10;

        private int index;
        private ObjectPool<GameObject> objectPool;
        #endregion

        #region 方法
        /// <summary>
        /// 建立物件池物件
        /// </summary>
        /// <returns></returns>
        private GameObject CreateObject()
        {
            GameObject chestObject = Instantiate(goTarget);
            index++;
            chestObject.name = goTarget.name + index;
            return chestObject;
        }
        /// <summary>
        /// 跟物件池拿東西
        /// </summary>
        /// <param name="objectInPool"></param>
        private void GetObject(GameObject objectInPool)
        {
            objectInPool.SetActive(true);
        }
        /// <summary>
        /// 把物件還給物件池
        /// </summary>
        /// <param name="objectInPool"></param>
        private void ReleaseObject(GameObject objectInPool)
        {
            objectInPool.SetActive(false);
        }
        /// <summary>
        /// 當數量超出物件池最大值時
        /// </summary>
        /// <param name="objectInPool"></param>
        private void DestroyObject(GameObject objectInPool)
        {
            Destroy(objectInPool);
        }

        private void Test()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GetPoolObject();
            }
        }
        #endregion

        #region 事件
        private void Awake()
        {
            objectPool = new ObjectPool<GameObject>(CreateObject,GetObject,ReleaseObject,DestroyObject,maxSize:countMax);
        }
        private void Update()
        {
            Test();
        }
        #endregion

        #region 公開方法
        /// <summary>
        /// 跟物件池拿東西
        /// </summary>
        /// <returns></returns>
        public GameObject GetPoolObject()
        {
            return objectPool.Get();
        }
        /// <summary>
        /// 還東西給物件池
        /// </summary>
        /// <param name="objectToRelease"></param>
        public void ReleasePoolObject(GameObject objectToRelease) 
        {
            objectPool.Release(objectToRelease);
        }
        #endregion
    }

}