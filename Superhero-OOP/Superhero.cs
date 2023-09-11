using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Superhero_OOP
{
    internal class Superhero
    {
        // Strings
        private string power;
        private string ability;
        private string skills;
        private string fear;
        private string actuallyName;

        // Bools
        private bool secretIdentity;
        private bool wearMask;
        private bool wearCostume;
        private bool hasMoralCode;
        private bool hasNemesis;

        // Strings

        public string ActuallyName
        {
            get { return actuallyName; }
            private set { actuallyName = value; }

        }

        public string Power
        { 
            get { return power; }
            private set { power = value; }
        }

        public string Ability
        {
            get { return ability; }
            private set { ability = value; }
        }

        public string Skills
        {
            get { return skills; }
            private set { skills = value; }
        }

        public string Fear
        {
            get { return fear; }
            private set { fear = value; }
        }


        // Bools

        public bool SecretIdentity
        {
            get { return secretIdentity; }
            private set { secretIdentity = value; }
        }

        public bool WearMask
        {
            get { return wearMask; }
            private set { wearMask = value; }
        }

        public bool WearCostume
        {
            get { return wearCostume; }
            private set {  wearCostume = value; }
        }

        public bool MoralCode
        {
            get { return hasMoralCode;  }
            private set { hasMoralCode = value; }
        }

        public bool HasNemesis
        {
            get { return hasNemesis; }
            private set { hasNemesis = value; }
        }
    }
}
