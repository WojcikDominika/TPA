﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TPApplicationCore.Model
{
    [DataContract]
    public class FieldMetadata
    {
        #region private
        [DataMember]
        private string name;
        [DataMember]
        private TypeMetadata type;
        #endregion
        
        public FieldMetadata(string name, TypeMetadata type)
        {
            this.name = name;
            this.type = type;
        }

        public string getName()
        {
            return name;
        }
        public TypeMetadata getType()
        {
            return type;
        }

        public bool anyChildren()
        {
            return type.anyChildren();
        }
    }
}
