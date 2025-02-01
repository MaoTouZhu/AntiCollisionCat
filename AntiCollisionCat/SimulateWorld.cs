using AntiCollisionCat.API;
using Jitter2;
using Jitter2.Collision.Shapes;
using Jitter2.Dynamics;
using Jitter2.LinearMath;
using System.Diagnostics;

namespace AntiCollisionCat
{
    /// <summary>
    /// 模拟世界
    /// </summary>
    public class SimulateWorld : IHasName
    {
        /// <summary>
        /// 默认世界
        /// </summary>
        public SimulateWorld(string name)
        {
            Name = name;
            World = GetDefaltWorld();
        }

        /// <summary>
        /// 内部世界
        /// </summary>
        public World World { get; protected set; }


        /// <summary>
        /// 每秒Tick数
        /// </summary>
        public int TPS { get; set; } = 20;

        /// <summary>
        /// 每Tick性能消耗 ms数
        /// </summary>
        public float MTPS { get; internal set; } = 0.0f;

        /// <inheritdoc/>
        public string Name { get; set; }

        /// <summary>
        /// 执行一个Tick
        /// </summary>
        private void Tick() => World.Step(1.0f / TPS, false);

        bool workFlag = false;
        /// <summary>
        /// 工作线程
        /// </summary>
        private void Work()
        {
            long lastTick = 0;
            Stopwatch stopwatch = new Stopwatch();
            while (workFlag)
            {
                UpdateObject(lastTick, stopwatch.ElapsedMilliseconds);
                lastTick = stopwatch.ElapsedMilliseconds;
                Tick();
                foreach (var body in World.RigidBodies)
                {
                    if (body.Contacts.Count > 0)
                    {
                        var another = body.Contacts.First().Body2;
                        OnCollision(body, another);
                        break;
                    }
                }
                while ((stopwatch.ElapsedMilliseconds - lastTick) < (1000 / TPS))
                {
                }
            }
        }

        private void OnCollision(RigidBody body, RigidBody another)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        private void UpdateObject(long lastTick, long thisTick)
        {
            throw new NotImplementedException();
        }

        private static World GetDefaltWorld()
        {
            World.Capacity capacity = new World.Capacity
            {
                BodyCount = 1_000,
                ConstraintCount = 1_000,
                ContactCount = 1_000,
                SmallConstraintCount = 1_000,
            };
            World world = new World(capacity);

            world.SpeculativeRelaxationFactor = 0.1f; //预测接触减速
            world.DynamicTree.Filter = World.DefaultDynamicTreeFilter; //默认动态树过滤器, 单个刚体忽略碰撞
            world.Gravity = JVector.Zero;//关闭重力
            world.EnableAuxiliaryContactPoints = false; //关闭辅助接触点
            world.SubstepCount = 1; //不采用子步
            world.SolverIterations = (6, 4);//求解器精度等级
            world.BroadPhaseFilter = null; //无碰撞过滤器 TODO: 说不定有呢

            return world;
        }
    }
}
