namespace BaseballPipeline.Shared.Services
{
    using BaseballPipeline.Shared.Models;

    public class FilterService
    {
        public FilterModel? Filters { get; set; }

        public event Action OnFilterChange;
        public void SetFilters(FilterModel filters)
        {
            Filters = filters;
            NotifyFilterChanged();
        }
        private void NotifyFilterChanged() => OnFilterChange?.Invoke();
        }
}
