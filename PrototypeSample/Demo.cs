using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeSample
{
    abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    class ConcretePrototype : Prototype
    {
        private Member member;

        public Member Member
        {
            get { return member; }
            set { member = value; }
        }

        private string attr; //成员变量

        public string Attr
        {
            get { return attr; }
            set { attr = value; }
        }

        //克隆方法
        public override Prototype Clone()
        {
            ConcretePrototype prototype = new ConcretePrototype();
            //prototype.Attr = this.Attr;
            //this.Attr = "Sunny";
            //prototype.Attr = new String(this.Attr.ToCharArray());
            //prototype.Member = this.Member;
            prototype.Member = new Member();
            return prototype;
        }
    }
}
