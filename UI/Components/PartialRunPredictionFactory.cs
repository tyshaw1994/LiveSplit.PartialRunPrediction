using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class PartialRunPredictionFactory : IComponentFactory
    {
        public string ComponentName => "Partial Run Prediction";

        public string Description => "Displays what the run time would be up to a certain split if the run continues at the same pace as a set comparison.";

        public ComponentCategory Category => ComponentCategory.Information; 

        public IComponent Create(LiveSplitState state) => new PartialRunPrediction(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.0.0");
    }
}
