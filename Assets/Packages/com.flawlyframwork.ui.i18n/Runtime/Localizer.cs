using UnityEditor;

namespace FF.I18N
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    [Serializable]
    public class Localizer : ILocalizer
    {
        [SerializeField] private List<LocalizeTarget> _targets;

        public string key { get; set; }

        public void SetParam(params object[] args)
        {
            
        }

        public void Localize()
        {
        }

        public void ForceLocalize(PlayerSettings.Switch.Languages languages)
        {
            throw new NotImplementedException();
        }
    }
}