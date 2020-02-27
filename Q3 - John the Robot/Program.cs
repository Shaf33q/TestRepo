using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3___John_the_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined
            Console.Read();

        }
    }
    public interface ISkill
    {
        string Show();
    }
    class Dancing : ISkill
    {
        public string Show() { return "dancing"; }
    }
    class Cooking : ISkill
    {
        public string Show() { return "cooking"; }
    }
    class NoSkill : ISkill
    {
        public string Show() { return "no skill is defined"; }
    }
    class Humanoid
    {
        private ISkill _skill;
        public Humanoid()
        {
            this._skill = new NoSkill();
        }
        public Humanoid(ISkill skill)
        {
            this._skill = skill;
        }
        public string ShowSkill() { return this._skill.Show(); }
    }
}
