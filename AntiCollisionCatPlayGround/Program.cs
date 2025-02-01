global using Jitter2;
global using Jitter2.Collision;
global using Jitter2.Collision.Shapes;
global using Jitter2.Dynamics;
global using Jitter2.LinearMath;
global using Jitter2.Parallelization;
global using Jitter2.UnmanagedMemory;
using System.Diagnostics;
using System.Xml.Serialization;


namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
            return;
        }

        static void Test()
        {
            Dictionary<ulong, string> AxisMap = new();
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


            //第一个X轴从-1000 位置以 1000的速度向 0移动
            RigidBodyShape boxShape1 = new BoxShape(1.0f, 1.0f, 1.0f);
            RigidBody body1 = world.CreateRigidBody();
            body1.AddShape(boxShape1);
            body1.Position = new JVector(-300.0f, 0.0f, 0.0f);
            body1.Velocity = new JVector(1000.0f, 0.0f, 0.0f);
            body1.Friction = 0.0f;
            body1.Restitution = 0.0f;
            body1.Damping = (0, 0);
            body1.EnableSpeculativeContacts = false;
            AxisMap[body1.RigidBodyId] = "X轴";

            //第二个Y轴从-1000 位置以 1000的速度向 0移动
            RigidBodyShape boxShape2 = new BoxShape(1.0f, 1.0f, 1.0f);
            RigidBody body2 = world.CreateRigidBody();
            body2.AddShape(boxShape2);
            body2.Position = new JVector(0.0f, -300.0f, 0.0f);
            body2.Velocity = new JVector(0.0f, 1000.0f, 0.0f);
            body2.Friction = 0.0f;
            body2.Restitution = 0.0f;
            body2.Damping = (0, 0);
            body2.EnableSpeculativeContacts = false;
            AxisMap[body2.RigidBodyId] = "Y轴";


            var start = Stopwatch.StartNew();
            int TPS = 20;
            float dt = 1f / TPS;

            // 运行模拟
            for (int i = 0; i < 500; i++)
            {
                world.Step(dt, false); //步进
                Console.WriteLine($"Step {i + 1}:");
                Console.WriteLine($"X轴 Position: {body1.Position}");
                Console.WriteLine($"Y轴 Position: {body2.Position}\r\n");

                if (body1.Contacts.Count > 0)
                {
                    Console.WriteLine("===============================");
                    start.Stop();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i * dt * 1000} ms 后将产生碰撞, 监测时间 {start.ElapsedMilliseconds} ms ");
                    var msg = $"碰撞物体是 [{AxisMap[body1.Contacts.First().Body1.RigidBodyId]}] 和 " +
                        $"[{AxisMap[body1.Contacts.First().Body2.RigidBodyId]}]";
                    Console.WriteLine(msg);
                    break;
                }
            }
        }
    }

    public class TickHelper
    {
        DateTime Time { get; set; }
        public TickHelper()
        {
            Time = DateTime.Now;
        }

        public void Tick(string msg = "")
        {
            Console.WriteLine($"{DateTime.Now: ss fff} {(DateTime.Now - Time).TotalMilliseconds} ms : {msg}");
            Time = DateTime.Now;
        }
    }
}
