using AntiCollisionCat.API;
using Jitter2;
using Jitter2.Collision.Shapes;
using Jitter2.Dynamics;
using Jitter2.LinearMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat
{
    /// <summary>
    /// 
    /// </summary>
    public class SimulateWorld
    {
        /// <summary>
        /// 内部世界
        /// </summary>
        public World World { get; protected set; }





        /// <summary>
        /// 世界向前演化一段时间
        /// </summary>
        /// <param name="seconds">向前演化的秒数</param>
        /// <param name="dt">切片时间间隔</param>
        /// <param name="multiThread">是否开启多线程</param>
        public void AdvanceWorld(int seconds, Real dt, bool multiThread)
        {
            int total = (int)(seconds / dt);
            for (int i = 0; i < total; i++)
                World.Step(dt, multiThread);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class T
    {
        static void Test()
        {

            World.Capacity capacity = new World.Capacity
            {
                BodyCount = 1_000,
                ConstraintCount = 1_000,
                ContactCount = 1_000,
                SmallConstraintCount = 1_000
            };
            // 创建World对象
            World world = new World(capacity);

            // 关闭重力
            world.Gravity = JVector.Zero;

            // 创建第一个长方体的形状和刚体
            RigidBodyShape boxShape1 = new BoxShape(1.0f, 1.0f, 1.0f);
            RigidBody body1 = world.CreateRigidBody();
            body1.Position = new JVector(-2.0f, 0.0f, 0.0f);
            body1.Velocity = new JVector(1.0f, 0.0f, 0.0f);
            body1.Friction = 0.0f;
            body1.Restitution = 1.0f;

            // 创建第二个长方体的形状和刚体
            RigidBodyShape boxShape2 = new BoxShape(1.0f, 1.0f, 1.0f);
            RigidBody body2 = world.CreateRigidBody();
            body2.Position = new JVector(2.0f, 0.0f, 0.0f);
            body2.Velocity = new JVector(-1.0f, 0.0f, 0.0f);
            body2.Friction = 0.0f;
            body2.Restitution = 1.0f;

            // 运行模拟
            for (int i = 0; i < 100; i++)
            {
                world.Step(1.0f / 60.0f); // 每步模拟1/60秒
                Console.WriteLine($"Step {i + 1}:");
                Console.WriteLine($"Body1 Position: {body1.Position}");
                Console.WriteLine($"Body2 Position: {body2.Position}");
            }
        }
    }

}
