﻿using OnlineServices.Common.DataAccessHelpers;
using OnlineServices.Common.TranslationServices.TransfertObjects;
using System.Collections.Generic;

namespace OnlineServices.Common.FacilityServices.TransfertObjects
{
    public class ComponentTypeTO : IEntity<int>
    {
        public int Id { get; set; }
        public MultiLanguageString Name { get; set; }
        public bool Archived { get; set; }
    }
}
