using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    public class Category : IComparable
    {
        public readonly String name;
        public readonly MessageType messageType;
        public readonly MessageTopic messageTopic;

        public Category(String categoryName, MessageType type, MessageTopic topic)
        {
            name = categoryName;
            messageType = type;
            messageTopic = topic;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null) return false;
            if (this.CompareTo(obj) == 0) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return (string)name + '.' + messageType + '.' + messageTopic;
        }

        public int CompareTo(Object obj)
        {
            Category objToCat;
            if (obj is Category)
            {
                objToCat = (Category)obj;
            }
            else return -1;
            if ((this.name == null)||(objToCat.name==null))return -1;
            int nameCompare = this.name.CompareTo(objToCat.name);
            if (nameCompare != 0) return nameCompare;
            int typeCompare = this.messageType.CompareTo(objToCat.messageType);
            if (typeCompare != 0) return typeCompare;
            return this.messageTopic.CompareTo(objToCat.messageTopic);
        }

        public static bool operator <(Category cat1, Category cat2)
        {
            if (cat1.CompareTo(cat2) < 0) return true;
            return false;
        }

        public static bool operator >(Category cat1, Category cat2)
        {
            if (cat1.CompareTo(cat2) > 0) return true;
            return false;
        }

        public static bool operator <=(Category cat1, Category cat2)
        {
            if (cat1.CompareTo(cat2) <= 0) return true;
            return false;
        }

        public static bool operator >=(Category cat1, Category cat2)
        {
            if (cat1.CompareTo(cat2) >= 0) return true;
            return false;
        }

        public static bool operator ==(Category cat1, Category cat2)
        {
            if (cat1.CompareTo(cat2) == 0) return true;
            return false;
        }

        public static bool operator !=(Category cat1, Category cat2)
        {
            if (cat1.CompareTo(cat2) != 0) return true;
            return false;
        }


    }
}
