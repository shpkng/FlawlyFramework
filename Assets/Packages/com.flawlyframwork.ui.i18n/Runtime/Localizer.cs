using System;
using System.Collections.Generic;
using UnityEngine;

namespace FF.I18N
{
    [Serializable]
    public class Localizer: ILocalizable
    {
        [SerializeField] private List<LocalizeTarget> _targets; 
        
        public void Localize()
        {
            
        }
    }
}