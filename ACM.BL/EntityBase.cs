﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    // Så att EntityStateOption funkar i get set längre ner
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    // Kan bara användas som en base class då den är abstract
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid
        {
            get { return Validate(); }
        }
        // public bool IsValid => Validate(); är samma som den över fast med landa expression

        public abstract bool Validate();
        
    }
}
