using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Managers
{
    internal class MemberManager
    {
        public List<Member> members = new();

        public Member Get(int index)
        {
            if (CheckIndex(index))
                return members[index];
            else
                return null;
        }


        public void Add(Member member)
        {
            members.Add(member);
        }


        public int Count
        {
            get { return members.Count; }
        }


        private bool CheckIndex(int index)
        {
            return (index >= 0) && (index < members.Count);
        }


        public bool noMembersAvailable()
        {
            return (members == null) || (members.Count <= 0);
        }

        //FIGURE OUT ID SYSTEM

        public void addTestMember()
        {
            for (int i = 0; i <10; i++)
            {
                Member m = new Member(10 + i, "Member" + (i + 1));
                m.ID = 10 + i;
                m.Name = "Member" + (i + 1);
                members.Add(m);
            }
        }
    }
}
