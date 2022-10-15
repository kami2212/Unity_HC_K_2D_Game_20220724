using UnityEngine;

namespace Su
{
    /// <summary>
    /// 玩家攻擊系統
    /// </summary>
    public class PlayerAttack : AttackSystem
    {
        [SerializeField, Header("攻擊輸入按鍵")]
        private KeyCode keyAttack = KeyCode.Mouse0;
        private SystemScript movesystem;
        private JumpSystem jumpSystem;

        protected override void Awake()
        {
            base.Awake();
            movesystem = GetComponent<SystemScript>();
            jumpSystem = GetComponent<JumpSystem>();
        }
        private void Update()
        {
            InputCheck();
        }
        /// <summary>
        /// 檢查輸入攻擊按鍵
        /// </summary>
        private void InputCheck()
        {
            if(Input.GetKeyDown(keyAttack))
            {
                StartAttack();
            }
        }

        public override void StartAttack()
        {
            base.StartAttack();

            movesystem.enabled = false;
            jumpSystem.enabled = false;
        }
        protected override void StopAttack()
        {
            base.StopAttack();
            movesystem.enabled = true;
            jumpSystem.enabled = true;
        }
    }
}

