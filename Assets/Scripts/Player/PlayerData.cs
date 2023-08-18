using UnityEngine;

namespace KillChain.Player
{
    [CreateAssetMenu(menuName = "KillChain/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        #region Movement
        [Space]
        [Header("Movement")]
        [Tooltip("Speed of basic movement.")]
        [SerializeField] private float _moveSpeed;
        public float MoveSpeed => _moveSpeed;

        [Tooltip("Max speed player can reach.")]
        [SerializeField] private float _maxSpeed;
        public float MaxSpeed => _maxSpeed;

        [Tooltip("Max speed player can reach while in air.")]
        [SerializeField] private float _maxAirSpeed;
        public float MaxAirSpeed => _maxAirSpeed;

        [Tooltip("Force applied upwards when jumping.")]
        [SerializeField] private float _jumpForce;
        public float JumpForce => _jumpForce;

        [Tooltip("Movement speed multiplier while in air.")]
        [SerializeField] private float _airSpeedMultiplier;
        public float AirSpeedMultiplier => _airSpeedMultiplier;
        #endregion

        #region Drag
        [Space]
        [Header("Drag")]
        [Tooltip("Rigidbody drag while grounded.")]
        [SerializeField] private float _groundDrag;
        public float GroundDrag => _groundDrag;

        [Tooltip("Rigidbody drag while in air.")]
        [SerializeField] private float _airDrag;
        public float AirDrag => _airDrag;
        #endregion

        #region Camera
        [Space]
        [Header("Camera")]
        [Tooltip("Camera horizontal sensitivity.")]
        [SerializeField] private float _horizontalSensitivity;
        public float HorizontalSensitivity => _horizontalSensitivity;

        [Tooltip("Camera vertical sesnitivity.")]
        [SerializeField] private float _verticalSensitivity;
        public float VerticalSensitivity => _verticalSensitivity;
        #endregion

        #region Slide
        [Space]
        [Header("Slide")]
        [SerializeField] private float _slideSpeed;
        public float SlideSpeed => _slideSpeed;
        #endregion

        #region Slam
        [Space]
        [Header("Slam")]
        [Tooltip("Damage dealt by slam ability.")]
        [SerializeField] private int _slamDamage;
        public int SlamDamage => _slamDamage;

        [Tooltip("Speed player will move downwards when slamming.")]
        [SerializeField] private float _slamSpeed;
        public float SlamSpeed => _slamSpeed;
        #endregion

        #region Weapon
        [Space]
        [Header("Weapon")]
        [Tooltip("Max distance player can chain to target from.")]
        [SerializeField] private float _maxTargetDistance;
        public float MaxTargetDistance => _maxTargetDistance;
        #endregion

        #region Dash
        [Space]
        [Header("Dash")]
        [Tooltip("Damage of dash ability.")]
        [SerializeField] private int _dashDamage;
        public int DashDamage => _dashDamage;

        [Tooltip("Speed while dashing to chained target.")]
        [SerializeField] private float _dashSpeed;
        public float DashSpeed => _dashSpeed;

        [Tooltip("Speed applied to player after reaching dash target. (Non-damageables)")]
        [SerializeField] private float _dashReboundSpeed;
        public float DashReboundSpeed => _dashReboundSpeed;

        [Tooltip("Upwards force applied to player after reaching dash target. (Non-damageables)")]
        [SerializeField] private float _dashReboundUpwardForce;
        public float DashReboundUpwardForce => _dashReboundUpwardForce;

        [Tooltip("Upwards force applied to player aftering damaging chained target with dash.")]
        [SerializeField] private float _dashDamageUpwardForce;
        public float DashDamageUpwardForce => _dashDamageUpwardForce;

        [Tooltip("Distance dash will damaged chained target from.")]
        [SerializeField] private float _dashDamageDistance;
        public float DashDamageDistance => _dashDamageDistance;
        #endregion

        #region Pull
        [Space]
        [Header("Pull")]
        [Tooltip("Speed chained targets are pulled.")]
        [SerializeField] private float _pullSpeed;
        public float PullSpeed => _pullSpeed;

        [Tooltip("Distance where chained target will stop being pulled.")]
        [SerializeField] private float _pullStopDistance;
        public float PullStopDistance => _pullStopDistance;
        #endregion

        #region Melee
        [Space]
        [Header("Melee")]
        [Tooltip("Damage of melee ability.")]
        [SerializeField] private int _meleeDamage;
        public int MeleeDamage => _meleeDamage;

        [Tooltip("Cooldown of melee ability.")]
        [SerializeField] private float _meleeCooldown;
        public float MeleeCooldown => _meleeCooldown;

        [Tooltip("Length of melee capsule hitbox.")]
        [SerializeField] private float _meleeLength;
        public float MeleeLength => _meleeLength;

        [Tooltip("Radius of melee capsule hitbox.")]
        [SerializeField] private float _meleeRadius;
        public float MeleeRadius => _meleeRadius;
        #endregion

        #region Parry
        [Space]
        [Header("Parry")]
        [SerializeField] private float _parryTimeStopDuration;
        public float ParryTimeStopDuration => _parryTimeStopDuration;

        [SerializeField] private float _parryVelocityMultiplier;
        public float ParryVelocityMultiplier => _parryVelocityMultiplier;
        #endregion
    }
}
