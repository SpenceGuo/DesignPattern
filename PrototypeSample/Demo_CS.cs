using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeSample
{
    class Member
    {

    }

    class ConcretePrototypeA
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
        public ConcretePrototypeA Clone()
        {
            return (ConcretePrototypeA)this.MemberwiseClone();
        }
    }

    class ConcretePrototypeB : ICloneable
    {
        private Member member;

        public Member Member
        {
            get { return member; }
            set { member = value; }
        }

        public object Clone()
        {
            ConcretePrototypeB copy = (ConcretePrototypeB)this.MemberwiseClone();
            Member newMember = new Member();
            copy.Member = newMember;
            return copy;
        }
    }
}
