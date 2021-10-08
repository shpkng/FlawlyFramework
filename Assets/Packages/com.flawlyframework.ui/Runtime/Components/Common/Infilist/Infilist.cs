// Author: wuchenyang(shpkng@gmail.com)

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FF.UI
{
    public enum InfilistType
    {
        Horizontal,
        Vertical,
        Grid
    }

    [Flags]
    public enum InfilistMoveType
    {
        Horizontal,
        Vertical
    }

    /// <summary>
    /// Infinity | List => Infilist
    /// </summary>
    [RequireComponent(typeof(ScrollRect))]
    public class Infilist : MonoBehaviour
    {
        [SerializeField] private bool fixSize;
        [SerializeField] private float fixedWidth = 100, fixedHeight = 100, padding = 0;
        [SerializeField] private InfilistType listType = InfilistType.Vertical;
        [SerializeField] private InfilistMoveType moveType = InfilistMoveType.Vertical;

        private Func<int, IInfilistItem> itemGetter;
        private Action<IInfilistItem> itemReturner;
        private List<IInfilistItem> listItems;

        private int maxIndexExisting, minIndexExisting, maxIndexVisible, minIndexVisible, totalCount;

        // moveToPosition = -1 means stay where it is
        private void SetCount(int count, int moveToPosition = -1)
        {
            if (totalCount == count)
                return;
            totalCount = count;
            Refresh(moveToPosition);
        }
        
        /// <param name="moveToPosition">-1: stay</param>
        private void Refresh(int moveToPosition = -1)
        {
            switch (listType)
            {
                case InfilistType.Vertical:
                    RefreshVertical();
                    break;
                case InfilistType.Horizontal:
                    RefreshHorizontal();
                    break;
                case InfilistType.Grid:
                    RefreshGrid();
                    break;
            }
        }

        private void RefreshHorizontal()
        {
            
        }

        private void RefreshGrid()
        {
            
        }

        private void RefreshVertical()
        {
            
        }
    }
}
