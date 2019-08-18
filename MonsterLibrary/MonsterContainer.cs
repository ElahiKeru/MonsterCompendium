using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MonsterLibrary
{
    public class MonsterContainer : IEnumerable<Monster>
    {
        private readonly string monsterPath;
        private List<Monster> monsters;

        public List<Monster> Monsters
        {
            get
            {
                if(monsters == null)
                {
                    monsters = new List<Monster>();
                }
                return monsters;
            }
            set
            {
                monsters = value;
            }
        }

        public MonsterContainer(string xmlPath)
        {
            monsterPath = xmlPath;
            ProcessMonsterList();
        }

        public MonsterContainer()
        {

        }

        private void ProcessMonsterList()
        {
            XmlDocument inputDoc = new XmlDocument();
            inputDoc.Load(monsterPath);

            XmlNodeList monsterSet = inputDoc.GetElementsByTagName("monster");

            foreach(XmlNode xn in monsterSet)
            {
                Monsters.Add(new Monster(xn));
            }
        }

        public Monster this[string index]
        {
            get
            {
                if (monsters == null) monsters = new List<Monster>();
                Monster target = null;
                foreach(Monster m in monsters)
                {
                    if(m.Name.Equals(index))
                    {
                        target = m;
                    }
                }
                return target;
            }
        }

        public Monster this[int index]
        {
            get
            {
                if (monsters == null) monsters = new List<Monster>();
                return monsters[index];
            }
        }

        public void Add(Monster target)
        {
            Monsters.Add(target);
        }

        public void Remove(string target)
        {
            Monsters.Remove(this[target]);
        }

        public IEnumerator<Monster> GetEnumerator()
        {
            return ((IEnumerable<Monster>)Monsters).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Monster>)Monsters).GetEnumerator();
        }

    }
}
