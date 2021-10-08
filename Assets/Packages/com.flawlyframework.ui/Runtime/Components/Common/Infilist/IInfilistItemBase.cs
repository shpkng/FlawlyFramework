// Author: wuchenyang(shpkng@gmail.com)

namespace FF.UI
{
    public interface IInfilistItem
    {
        public float height { get; }
        public float width { get; }
        public void SetData(object data);
    }
}